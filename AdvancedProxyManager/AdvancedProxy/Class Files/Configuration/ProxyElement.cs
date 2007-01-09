using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;

namespace Fleischmann.AdvancedProxy.ProxyConfiguration
{
	public class ProxyElement: ConfigurationElement
	{
		#region Constructors
		/// <summary>
		/// Predefines the valid properties and prepares
		/// the property collection.
		/// </summary>
		static ProxyElement()
		{
			// Predefine properties here
			s_propName = new ConfigurationProperty(
				"Name",
				typeof(string),
				null,
				ConfigurationPropertyOptions.IsRequired
			);

			s_propAutoDetct = new ConfigurationProperty(
				"AutoDetect",
				typeof(bool),
				false,
				ConfigurationPropertyOptions.None
			);

			s_propUseAutoConfigScript = new ConfigurationProperty(
				"UseAutoConfigScript",
				typeof(bool),
				false,
				ConfigurationPropertyOptions.None
			);

			s_propAutoConfigScriptAddress = new ConfigurationProperty(
				"AutoConfigScriptAddress",
				typeof(string),
				string.Empty,
				ConfigurationPropertyOptions.None
			);

			s_propUseProxyServer = new ConfigurationProperty(
				"UseProxyServer",
				typeof(bool),
				false,
				ConfigurationPropertyOptions.None
			);

			s_propUseProxyServerAddress = new ConfigurationProperty(
				"UseProxyServerAddress",
				typeof(string),
				string.Empty,
				ConfigurationPropertyOptions.None
			);

			s_propUseProxyServerPort = new ConfigurationProperty(
				"UseProxyServerPort",
				typeof(string),
				string.Empty,
				ConfigurationPropertyOptions.None
			);

			s_propUseSameProxyServerForAll = new ConfigurationProperty(
				"UseSameProxyServerForAll",
				typeof(bool),
				false,
				ConfigurationPropertyOptions.None
			);

			s_propProxyURLCollection = new ConfigurationProperty(
				"ProxyURLs",
				typeof(ProxyURLCollection),
				null,
				ConfigurationPropertyOptions.None
			);

			s_propBypassProxyForLocalAddress = new ConfigurationProperty(
				"BypassProxyForLocalAddress",
				typeof(bool),
				false,
				ConfigurationPropertyOptions.None
			);

			s_propExcludeAddressesFromProxy = new ConfigurationProperty(
				"ExcludeAddressesFromProxy",
				typeof(string),
				string.Empty,
				ConfigurationPropertyOptions.None
			);

			s_properties = new ConfigurationPropertyCollection();

			s_properties.Add(s_propName);
			s_properties.Add(s_propAutoDetct);
			s_properties.Add(s_propUseAutoConfigScript);
			s_properties.Add(s_propAutoConfigScriptAddress);
			s_properties.Add(s_propUseProxyServer);
			s_properties.Add(s_propUseProxyServerAddress);
			s_properties.Add(s_propUseProxyServerPort);
			s_properties.Add(s_propProxyURLCollection);
			s_properties.Add(s_propUseSameProxyServerForAll);
			s_properties.Add(s_propBypassProxyForLocalAddress);
			s_properties.Add(s_propExcludeAddressesFromProxy);
		}
		#endregion

		#region Static Fields
		private static ConfigurationProperty s_propName;
		private static ConfigurationProperty s_propAutoDetct;
		private static ConfigurationProperty s_propUseAutoConfigScript;
		private static ConfigurationProperty s_propAutoConfigScriptAddress;
		private static ConfigurationProperty s_propUseProxyServer;
		private static ConfigurationProperty s_propUseProxyServerAddress;
		private static ConfigurationProperty s_propUseProxyServerPort;
		private static ConfigurationProperty s_propProxyURLCollection;
		private static ConfigurationProperty s_propUseSameProxyServerForAll;
		private static ConfigurationProperty s_propBypassProxyForLocalAddress;
		private static ConfigurationProperty s_propExcludeAddressesFromProxy;

		private static ConfigurationPropertyCollection s_properties;
		#endregion

         
		#region Properties
		/// <summary>
		/// Gets the Name setting.
		/// </summary>
		[ConfigurationProperty("Name", IsRequired=true)]
		public string Name
		{
			get { return (string)base[s_propName]; }
			set {base[s_propName] = value; }
		}

		[ConfigurationProperty("AutoDetect")]
		public bool AutoDetect
		{
			get { return (bool)base[s_propAutoDetct]; }
			set { base[s_propAutoDetct] = value; }
		}

		[ConfigurationProperty("UseAutoConfigScript")]
		public bool UseAutoConfigScript
		{
			get { return (bool)base[s_propUseAutoConfigScript]; }
			set { base[s_propUseAutoConfigScript] = value; }
		}

		[ConfigurationProperty("AutoConfigScriptAddress")]
		public string AutoConfigScriptAddress
		{
			get { return (string)base[s_propAutoConfigScriptAddress]; }
			set { base[s_propAutoConfigScriptAddress] = value; }
		}

		[ConfigurationProperty("UseProxyServer")]
		public bool UseProxyServer
		{
			get { return (bool)base[s_propUseProxyServer]; }
			set { base[s_propUseProxyServer] = value; }
		}

		[ConfigurationProperty("UseProxyServerAddress")]
		public string UseProxyServerAddress
		{
			get { return (string)base[s_propUseProxyServerAddress]; }
			set { base[s_propUseProxyServerAddress] = value; }
		}

		[ConfigurationProperty("UseProxyServerPort")]
		public string UseProxyServerPort
		{
			get { return (string)base[s_propUseProxyServerPort]; }
			set { base[s_propUseProxyServerPort] = value; }
		}

		/// <summary>
		/// Gets the ProxyURLs Collection.
		/// </summary>
		[ConfigurationProperty("ProxyURLs", IsRequired = true)]
		public ProxyURLCollection ProxyURLs
		{
			get { return (ProxyURLCollection)base[s_propProxyURLCollection]; }
			//set { base[s_propProxyURLCollection] = value; }
		}

		/// <summary>
		/// Gets the UseSameProxyServerForAll Collection.
		/// </summary>
		[ConfigurationProperty("UseSameProxyServerForAll")]
		public bool UseSameProxyServerForAll
		{
			get { return (bool)base[s_propUseSameProxyServerForAll]; }
			set { base[s_propUseSameProxyServerForAll] = value; }
		}

		/// <summary>
		/// Gets the BypassProxyForLocalAddress flag.
		/// </summary>
		[ConfigurationProperty("BypassProxyForLocalAddress")]
		public bool BypassProxyForLocalAddress
		{
			get { return (bool)base[s_propBypassProxyForLocalAddress]; }
			set { base[s_propBypassProxyForLocalAddress] = value; }
		}

		/// <summary>
		/// Get the Exlusion List
		/// </summary>
		[ConfigurationProperty("ExcludeAddressesFromProxy")]
		public string ExcludeAddressesFromProxy
		{
			get { return (string)base[s_propExcludeAddressesFromProxy]; }
			set { base[s_propExcludeAddressesFromProxy] = value; }
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
