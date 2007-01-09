using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;

namespace Fleischmann.AdvancedProxy.ProxyConfiguration
{
	public class ProxyURL : ConfigurationElement
	{
		#region Constructors
		/// <summary>
		/// Predefines the valid properties and prepares
		/// the property collection.
		/// </summary>
		static ProxyURL()
		{
			// Predefine properties here
			s_propProtocol = new ConfigurationProperty(
				"Protocol",
				typeof(string),
				null,
				ConfigurationPropertyOptions.IsRequired
			);

			s_propURL = new ConfigurationProperty(
				"URL",
				typeof(string),
				null,
				ConfigurationPropertyOptions.IsRequired
			);

			s_propPort = new ConfigurationProperty(
				"Port",
				typeof(string),
				null,
				ConfigurationPropertyOptions.IsRequired
			);

			s_properties = new ConfigurationPropertyCollection();

			s_properties.Add(s_propProtocol);
			s_properties.Add(s_propURL);
			s_properties.Add(s_propPort);
		}
		#endregion

		#region Static Fields
		private static ConfigurationProperty s_propProtocol;
		private static ConfigurationProperty s_propURL;
		private static ConfigurationProperty s_propPort;

		private static ConfigurationPropertyCollection s_properties;
		#endregion


		#region Properties
		/// <summary>
		/// Gets the Name setting.
		/// </summary>
		[ConfigurationProperty("Protocol", IsRequired = true, IsKey = true)]
		public string Protocol
		{
			get { return (string)base[s_propProtocol]; }
			set { base[s_propProtocol] = value; }
		}

		/// <summary>
		/// Gets the Name setting.
		/// </summary>
		[ConfigurationProperty("URL", IsRequired = true)]
		public string URL
		{
			get { return (string)base[s_propURL]; }
			set { base[s_propURL] = value; }
		}

		/// <summary>
		/// Gets the Name setting.
		/// </summary>
		[ConfigurationProperty("Port", IsRequired = true)]
		public string Port
		{
			get { return (string)base[s_propPort]; }
			set { base[s_propPort] = value; }
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
