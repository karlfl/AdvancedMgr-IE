using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;

namespace Fleischmann.AdvancedProxy.ProxyConfiguration
{
	/// <summary>
	/// An example configuration section class.
	/// </summary>
	public class ProxyDefinitionSection : ConfigurationSection
	{
		#region Constructors
		/// <summary>
		/// Predefines the valid properties and prepares
		/// the property collection.
		/// </summary>
		static ProxyDefinitionSection()
	    {
			// Predefine properties here
			s_propDefaultProxyElement = new ConfigurationProperty(
				"DefaultProxyElement",
				typeof(string),
				null,
				ConfigurationPropertyOptions.None
			);

			s_propProxyElementCollection = new ConfigurationProperty(
				"ProxyDefinitions",
				typeof(ProxyElementCollection),
				null,
				ConfigurationPropertyOptions.None
			);

			s_properties = new ConfigurationPropertyCollection();

			s_properties.Add(s_propDefaultProxyElement);
			s_properties.Add(s_propProxyElementCollection);
		}
		#endregion

		#region Static Fields
		private static ConfigurationProperty s_propDefaultProxyElement;
		private static ConfigurationProperty s_propProxyElementCollection;

		private static ConfigurationPropertyCollection s_properties;
		#endregion

		#region Properties
		/// <summary>
		/// Gets the DefaultProxyElement setting.
		/// </summary>
		[ConfigurationProperty("DefaultProxyElement", IsRequired = true)]
		public string DefaultProxyElement
		{
			get { return (string)base[s_propDefaultProxyElement]; }
		}

		/// <summary>
		/// Gets the ProxyDefinitions Collection.
		/// </summary>
		[ConfigurationProperty("ProxyDefinitions", IsRequired = true)]
		public ProxyElementCollection ProxyDefinitions
		{
			get { return (ProxyElementCollection)base[s_propProxyElementCollection]; }
		}

		
		/// <summary>
		/// Override the Properties collection and return our custom one.
		/// </summary>
		protected override ConfigurationPropertyCollection Properties
		{
			get { return s_properties; }
		}
		#endregion
	}
}
