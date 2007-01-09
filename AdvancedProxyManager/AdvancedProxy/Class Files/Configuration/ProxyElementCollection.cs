using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;

namespace Fleischmann.AdvancedProxy.ProxyConfiguration
{
	[ConfigurationCollection(typeof(ProxyElement), CollectionType = ConfigurationElementCollectionType.BasicMap)]
	public class ProxyElementCollection : ConfigurationElementCollection
	{
		#region Constructors
		static ProxyElementCollection()
		{
			m_properties = new ConfigurationPropertyCollection();
		}

		public ProxyElementCollection()
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
			get { return ConfigurationElementCollectionType.BasicMap; }
		}

		protected override string ElementName
		{
			get { return "Proxy"; }
		}
		#endregion

		#region Indexers
		public ProxyElement this[int index]
		{
			get { return (ProxyElement)base.BaseGet(index); }
			set
			{
				if (base.BaseGet(index) != null)
				{
					base.BaseRemoveAt(index);
				}
				base.BaseAdd(index, value);
			}
		}

		public ProxyElement this[string name]
		{
			get { return (ProxyElement)base.BaseGet(name); }
		}
		#endregion

		#region Methods
		public void Add(ProxyElement thing)
		{
			base.BaseAdd(thing);
		}

		public void Remove(string name)
		{
			base.BaseRemove(name);
		}

		public void Remove(ProxyElement thing)
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
			return new ProxyElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return (element as ProxyElement).Name;
		}
		#endregion
	}
}