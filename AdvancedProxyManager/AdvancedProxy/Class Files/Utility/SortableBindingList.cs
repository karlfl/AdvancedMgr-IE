using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Fleischmann.AdvancedProxy
{
	/// <summary>
	/// Original Code by Joe Stegman
	/// Found in MSDN Forums 
	/// http://forums.microsoft.com/MSDN/ShowPost.aspx?PostID=65826&SiteID=1
	/// 
	/// Joe States...
	/// BindingList<T> does not directly support sorting, however you can 
	/// sub-class it to provide this behavior.  The following article has a 
	/// sample of a sub-classed BindingList<T> that provides sorting:
	///    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dnforms/html/winforms11162004.asp
	/// 
	/// </summary>
	[Serializable()]
	public class SortableBindingList<T> : BindingList<T>
	{
		private bool _isSorted;
		private ListSortDirection _dir = ListSortDirection.Ascending;

		[NonSerialized()]
		private PropertyDescriptor _sort = null;

		#region BindingList<T> Public Sorting API
		public void Sort()
		{
			ApplySortCore(_sort, _dir);
		}

		public void Sort(string property)
		{
			/* Get the PD */
			_sort = FindPropertyDescriptor(property);

			/* Sort */
			ApplySortCore(_sort, _dir);
		}

		public void Sort(string property, ListSortDirection direction)
		{
			/* Get the sort property */
			_sort = FindPropertyDescriptor(property);
			_dir = direction;

			/* Sort */
			ApplySortCore(_sort, _dir);
		}
		#endregion

		#region BindingList<T> Sorting Overrides
		protected override ListSortDirection SortDirectionCore
		{
			get { return _dir; }
		}

		protected override PropertyDescriptor SortPropertyCore
		{
			get { return _sort; }
		}
		
		protected override bool SupportsSortingCore
		{
			get { return true; }
		}

		protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
		{
			List<T> items = this.Items as List<T>;

			if ((null != items) && (null != property))
			{
				PropertyComparer<T> pc = new PropertyComparer<T>(property, direction);
				items.Sort(pc);

				/* Set sorted */
				_isSorted = true;
				_sort = property;
				_dir = direction;
			}
			else
			{
				/* Set sorted */
				_isSorted = false;
			}

			// Let bound controls know they should refresh their views
			this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
		}

		protected override bool IsSortedCore
		{
			get { return _isSorted; }
		}

		protected override void RemoveSortCore()
		{
			_isSorted = false;
		}
		#endregion

		#region BindingList<T> Private Sorting API
		private PropertyDescriptor FindPropertyDescriptor(string property)
		{
			PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(typeof(T));
			PropertyDescriptor prop = null;

			if (null != pdc)
			{
				prop = pdc.Find(property, true);
			}

			return prop;
		}
		#endregion

		#region PropertyComparer<TKey>
		internal class PropertyComparer<TKey> : System.Collections.Generic.IComparer<TKey>
		{
			/*
			* The following code contains code implemented by Rockford Lhotka:
			* //msdn.microsoft.com/library/default.asp?url=/library/en-us/dnadvnet/html/vbnet01272004.asp" href="http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dnadvnet/html/vbnet01272004.asp">http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dnadvnet/html/vbnet01272004.asp
			*/

			private PropertyDescriptor _property;
			private ListSortDirection _direction;

			public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
			{
				_property = property;
				_direction = direction;
			}

			public int Compare(TKey xVal, TKey yVal)
			{
				/* Get property values */
				object xValue = GetPropertyValue(xVal, _property.Name);
				object yValue = GetPropertyValue(yVal, _property.Name);

				/* Determine sort order */
				if (_direction == ListSortDirection.Ascending)
				{
					return CompareAscending(xValue, yValue);
				}
				else
				{
					return CompareDescending(xValue, yValue);
				}
			}

			public bool Equals(TKey xVal, TKey yVal)
			{
				return xVal.Equals(yVal);
			}

			public int GetHashCode(TKey obj)
			{
				return obj.GetHashCode();
			}

			/* Compare two property values of any type */
			private int CompareAscending(object xValue, object yValue)
			{
				int result;

				/* If values implement IComparer */
				if (xValue is IComparable)
				{
					result = ((IComparable)xValue).CompareTo(yValue);
				}
				/* If values don't implement IComparer but are equivalent */
				else if (xValue.Equals(yValue))
				{
					result = 0;
				}
				/* Values don't implement IComparer and are not equivalent, so compare as string values */
				else result = xValue.ToString().CompareTo(yValue.ToString());

				/* Return result */
				return result;
			}

			private int CompareDescending(object xValue, object yValue)
			{
				/* Return result adjusted for ascending or descending sort order ie
				   multiplied by 1 for ascending or -1 for descending */
				return CompareAscending(xValue, yValue) * -1;
			}

			private object GetPropertyValue(TKey value, string property)
			{
				/* Get property */
				PropertyInfo propertyInfo = value.GetType().GetProperty(property);

				/* Return value */
				return propertyInfo.GetValue(value, null);
			}
		}
		#endregion
	}
}
