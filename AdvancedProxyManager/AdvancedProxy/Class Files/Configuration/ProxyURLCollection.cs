using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;

namespace Fleischmann.AdvancedProxy.ProxyConfiguration
{
	[ConfigurationCollection(typeof(ProxyURL), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
	public class ProxyURLCollection : ConfigurationElementCollection
	{
		#region Constructors
		static ProxyURLCollection()
		{
			m_properties = new ConfigurationPropertyCollection();
		}

		public ProxyURLCollection()
		{
		}
		#endregion

		#region Fields
		private static ConfigurationPropertyCollection m_properties;
		#endregion

		#region Properties
		protected override ConfigurationPropertyCollection Properties
		{
			get { return m_properties; }
		}

		public override ConfigurationElementCollectionType CollectionType
		{
			get { return ConfigurationElementCollectionType.AddRemoveClearMap; }
		}
		#endregion

		#region Indexers
		public ProxyURL this[int index]
		{
			get { return (ProxyURL)base.BaseGet(index); }
			set
			{
				if (base.BaseGet(index) != null)
				{
					base.BaseRemoveAt(index);
				}
				base.BaseAdd(index, value);
			}
		}

		public ProxyURL this[string name]
		{
			get { return (ProxyURL)base.BaseGet(name); }
		}
		#endregion

		#region Methods
		public void Add(ProxyURL thing)
		{
			base.BaseAdd(thing);
		}

		public void Remove(string name)
		{
			base.BaseRemove(name);
		}

		public void Remove(ProxyURL thing)
		{
			base.BaseRemove(GetElementKey(thing));
		}

		public void Clear()
		{
			base.BaseClear();
		}

		public void RemoveAt(int index)
		{
			base.BaseRemoveAt(index);
		}

		public string GetKey(int index)
		{
			return (string)base.BaseGetKey(index);
		}
		#endregion

		#region Overrides
		protected override ConfigurationElement CreateNewElement()
		{
			return new ProxyURL();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return (element as ProxyURL).Protocol;
		}
		#endregion
	}
}