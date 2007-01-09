using Microsoft.Win32;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;

using Fleischmann.AdvancedProxy.ProxyConfiguration;

namespace Fleischmann.AdvancedProxy
{
	/// <summary>
	/// Copyright karl fleischmann 2006-2007
	/// </summary>
	public class ProxySetting
	{
		const string BaseKey = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";

		private string _Name;
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		private bool _AutoDetectSettings;
		public bool AutoDetectSettings
		{
			get { return _AutoDetectSettings; }
			set { _AutoDetectSettings = value; }
		}

		private bool _UseAutoConfigureScript;
		public bool UseAutoConfigureScript
		{
			get { return _UseAutoConfigureScript; }
			set { _UseAutoConfigureScript = value; }
		}

		private string _UseAutoConfigureScriptAddress = "";
		public string UseAutoConfigureScriptAddress
		{
			get { return _UseAutoConfigureScriptAddress; }
			set { _UseAutoConfigureScriptAddress = value; }
		}

		private bool _UseProxyServer;
		public bool UseProxyServer
		{
			get { return _UseProxyServer; }
			set { _UseProxyServer = value; }
		}

		private string _UseProxyServerAddress = "";
		public string UseProxyServerAddress
		{
			get { return _UseProxyServerAddress; }
			set { _UseProxyServerAddress = value; }
		}

		private string _UseProxyServerPort;
		public string UseProxyServerPort
		{
			get { return _UseProxyServerPort; }
			set { _UseProxyServerPort = value; }
		}

		private bool _BypassProxyForLocalAddress;
		public bool BypassProxyForLocalAddress
		{
			get { return _BypassProxyForLocalAddress; }
			set { _BypassProxyForLocalAddress = value; }
		}

		private string _HTTPProxyAddress = "";
		public string HTTPProxyAddress
		{
			get { return _HTTPProxyAddress; }
			set { _HTTPProxyAddress = value; }
		}

		private string _HTTPProxyPort;
		public string HTTPProxyPort
		{
			get { return _HTTPProxyPort; }
			set { _HTTPProxyPort = value; }
		}

		private string _SecureProxyAddress = "";
		public string SecureProxyAddress
		{
			get { return _SecureProxyAddress; }
			set { _SecureProxyAddress = value; }
		}

		private string _SecureProxyPort;
		public string SecureProxyPort
		{
			get { return _SecureProxyPort; }
			set { _SecureProxyPort = value; }
		}

		private string _FTPProxyAddress = "";
		public string FTPProxyAddress
		{
			get { return _FTPProxyAddress; }
			set { _FTPProxyAddress = value; }
		}

		private string _FTPProxyPort;
		public string FTPProxyPort
		{
			get { return _FTPProxyPort; }
			set { _FTPProxyPort = value; }
		}

		private string _GopherProxyAddress = "";
		public string GopherProxyAddress
		{
			get { return _GopherProxyAddress; }
			set { _GopherProxyAddress = value; }
		}

		private string _GopherProxyPort;
		public string GopherProxyPort
		{
			get { return _GopherProxyPort; }
			set { _GopherProxyPort = value; }
		}

		private string _SocksProxyAddress = "";
		public string SocksProxyAddress
		{
			get { return _SocksProxyAddress; }
			set { _SocksProxyAddress = value; }
		}

		private string _SocksProxyPort;
		public string SocksProxyPort
		{
			get { return _SocksProxyPort; }
			set { _SocksProxyPort = value; }
		}

		private bool _UseSameProxyServerForAllProtocols;
		public bool UseSameProxyServerForAllProtocols
		{
			get { return _UseSameProxyServerForAllProtocols; }
			set { _UseSameProxyServerForAllProtocols = value; }
		}

		private string _ExcludeAddressesFromProxy;
		public string ExcludeAddressesFromProxy
		{
			get { return _ExcludeAddressesFromProxy; }
			set { _ExcludeAddressesFromProxy = value; }
		}

		public ProxySetting()
		{
		}

		public ProxySetting(ProxyElement configElement)
		{
			this.Name = configElement.Name;
			this.AutoDetectSettings = configElement.AutoDetect;
			this.UseAutoConfigureScript = configElement.UseAutoConfigScript;
			this.UseAutoConfigureScriptAddress = configElement.AutoConfigScriptAddress;
			this.UseProxyServer = configElement.UseProxyServer;
			this.UseProxyServerAddress = configElement.UseProxyServerAddress;
			this.BypassProxyForLocalAddress = configElement.BypassProxyForLocalAddress;
			this.UseProxyServerPort = configElement.UseProxyServerPort;
			this.ExcludeAddressesFromProxy = configElement.ExcludeAddressesFromProxy;
			this.UseSameProxyServerForAllProtocols = configElement.UseSameProxyServerForAll;
			if (configElement.ProxyURLs["HTTP"] != null)
			{
				this.HTTPProxyAddress = configElement.ProxyURLs["HTTP"].URL;
				this.HTTPProxyPort = configElement.ProxyURLs["HTTP"].Port.ToString();
			}
			if (configElement.ProxyURLs["HTTPS"] != null)
			{
				this.SecureProxyAddress = configElement.ProxyURLs["HTTPS"].URL;
				this.SecureProxyPort = configElement.ProxyURLs["HTTPS"].Port.ToString();
			}
			if (configElement.ProxyURLs["FTP"] != null)
			{
				this.FTPProxyAddress = configElement.ProxyURLs["FTP"].URL;
				this.FTPProxyPort = configElement.ProxyURLs["FTP"].Port.ToString();
			}
			if (configElement.ProxyURLs["Gopher"] != null)
			{
				this.GopherProxyAddress = configElement.ProxyURLs["Gopher"].URL;
				this.GopherProxyPort = configElement.ProxyURLs["Gopher"].Port.ToString();
			}
			if (configElement.ProxyURLs["Socks"] != null)
			{
				this.SocksProxyAddress = configElement.ProxyURLs["Socks"].URL;
				this.SocksProxyPort = configElement.ProxyURLs["Socks"].Port.ToString();
			}
		}

		public static List<ProxySetting> GetAllAdvancedProxies()
		{
			List<ProxySetting> list = new List<ProxySetting>();
			return list;
			
		}

		public static bool SetAsCurrentProxy(ProxySetting theProxy)
		{
			return true;
		}

		public static ProxySetting GetCurrentProxyFromRegistry()
		{
			ProxySetting returnProxy = new ProxySetting();
			returnProxy.UseProxyServer = Convert.ToBoolean(Registry.GetValue(BaseKey, "ProxyEnable", false));
			returnProxy.ExcludeAddressesFromProxy = Convert.ToString(Registry.GetValue(BaseKey, "ProxyOverride", ""));
			if (returnProxy.ExcludeAddressesFromProxy.EndsWith("<local>"))
			{
				returnProxy.BypassProxyForLocalAddress = true;
				returnProxy.ExcludeAddressesFromProxy = returnProxy.ExcludeAddressesFromProxy.Substring(0,returnProxy.ExcludeAddressesFromProxy.Length - 8);
			}
			else
			{
				returnProxy.BypassProxyForLocalAddress = false;
			}
			string proxyServerString = Convert.ToString(Registry.GetValue(BaseKey, "ProxyServer", ""));
			if (proxyServerString.Trim() != string.Empty)
			{
				string[] proxyServerList = proxyServerString.Split(';');
				if (proxyServerList.Length > 1)
				{
					returnProxy.UseSameProxyServerForAllProtocols = false;
					foreach (string aProxyServer in proxyServerList)
					{
						string[] proxyServer = aProxyServer.Split('=');
						string type = proxyServer[0];
						string[] ServerAddressAndPort = proxyServer[1].Split(':');
						switch (type)
						{
							case ("http"):
								returnProxy.HTTPProxyAddress = ServerAddressAndPort[0];
								returnProxy.HTTPProxyPort = ServerAddressAndPort[1];
								break;
							case ("https"):
								returnProxy.SecureProxyAddress = ServerAddressAndPort[0];
								returnProxy.SecureProxyPort = ServerAddressAndPort[1];
								break;
							case ("ftp"):
								returnProxy.FTPProxyAddress = ServerAddressAndPort[0];
								returnProxy.FTPProxyPort = ServerAddressAndPort[1];
								break;
							case ("gopher"):
								returnProxy.GopherProxyAddress = ServerAddressAndPort[0];
								returnProxy.GopherProxyPort = ServerAddressAndPort[1];
								break;
							case ("socks"):
								returnProxy.SocksProxyAddress = ServerAddressAndPort[0];
								returnProxy.SocksProxyPort = ServerAddressAndPort[1];
								break;
						}
					}
				}
				else
				{
					returnProxy.UseSameProxyServerForAllProtocols = true;
					string[] ServerAddressAndPort = proxyServerString.Split(':');
					returnProxy.UseProxyServerAddress = ServerAddressAndPort[0];
					returnProxy.UseProxyServerPort = ServerAddressAndPort[1];
				}

				returnProxy.Name = "Initial Proxy Settings";
				//returnProxy.Description = "Copy of proxy information found in current registry keys";
			}

			return returnProxy;
		}

		public bool SetAsCurrentProxy()
		{
			return true;
		}

		public bool SaveInConfigFile()
		{
			//Update config element values to the values on this class.
			Configuration myConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			ProxyDefinitionSection mySection = (ProxyDefinitionSection)myConfig.GetSection("ProxyDefinition");
			ProxyElement configElement = mySection.ProxyDefinitions[this.Name];
			//If this name isn't found add one.
			if (configElement == null)
			{
				configElement = new ProxyElement();
				configElement.Name = this.Name;
				mySection.ProxyDefinitions.Add(configElement);
			}
			configElement.Name = this.Name;
			configElement.AutoDetect = this.AutoDetectSettings;
			configElement.UseAutoConfigScript = this.UseAutoConfigureScript;
			configElement.AutoConfigScriptAddress = this.UseAutoConfigureScriptAddress;

			configElement.UseProxyServer = this.UseProxyServer;
			configElement.UseProxyServerAddress = this.UseProxyServerAddress;
			configElement.BypassProxyForLocalAddress = this.BypassProxyForLocalAddress;
			configElement.UseProxyServerPort = this.UseProxyServerPort;
			configElement.ExcludeAddressesFromProxy = this.ExcludeAddressesFromProxy;
			configElement.UseSameProxyServerForAll = this.UseSameProxyServerForAllProtocols;

			UpdateProxyAddressAndPort(this.HTTPProxyAddress, this.HTTPProxyPort, "HTTP", configElement);
			UpdateProxyAddressAndPort(this.SecureProxyAddress, this.SecureProxyAddress, "HTTPS", configElement);
			UpdateProxyAddressAndPort(this.FTPProxyAddress, this.FTPProxyPort, "FTP", configElement);
			UpdateProxyAddressAndPort(this.GopherProxyAddress, this.GopherProxyPort, "Gopher", configElement);
			UpdateProxyAddressAndPort(this.SocksProxyAddress, this.SocksProxyPort, "Socks", configElement);

			myConfig.Save();

			return true;
		}

		public bool Delete()
		{
			//Remove this config element
			Configuration myConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			ProxyDefinitionSection mySection = (ProxyDefinitionSection)myConfig.GetSection("ProxyDefinition");
			mySection.ProxyDefinitions.Remove(this.Name);
			myConfig.Save();

			return true;
		}

		private void UpdateProxyAddressAndPort(string ProxyAddress, string ProxyPort, string ProxyProtocol, ProxyElement configElement)
		{
			if (ProxyAddress != null &&
				ProxyAddress != string.Empty)
			{
				if (configElement.ProxyURLs[ProxyProtocol] != null)
				{
					//defined and in config file so just update it
					ProxyAddress = configElement.ProxyURLs[ProxyProtocol].URL;
					ProxyPort = configElement.ProxyURLs[ProxyProtocol].Port.ToString();
				}
				else
				{
					//not defined nor in config file so add it
					ProxyURL aURL = new ProxyURL();
					aURL.Protocol = ProxyProtocol;
					aURL.URL = ProxyAddress;
					aURL.Port = ProxyPort;
					configElement.ProxyURLs.Add(aURL);
				}
			}
			else
			{
				if (configElement.ProxyURLs[ProxyProtocol] != null)
				{
					//not defined but is in config file remove it
					configElement.ProxyURLs.Remove(configElement.ProxyURLs[ProxyProtocol]);
				}
			}
		}

		public ProxySetting Clone()
		{
			ProxySetting returnProxy = new ProxySetting();
			returnProxy.AutoDetectSettings = this.AutoDetectSettings;
			returnProxy.BypassProxyForLocalAddress = this.BypassProxyForLocalAddress;
			returnProxy.ExcludeAddressesFromProxy = this.ExcludeAddressesFromProxy;
			returnProxy.FTPProxyAddress = this.FTPProxyAddress;
			returnProxy.FTPProxyPort = this.FTPProxyPort;
			returnProxy.GopherProxyAddress = this.GopherProxyAddress;
			returnProxy.GopherProxyPort = this.GopherProxyPort;
			returnProxy.HTTPProxyAddress = this.HTTPProxyAddress;
			returnProxy.HTTPProxyPort = this.HTTPProxyPort;
			returnProxy.Name = this.Name;
			returnProxy.SecureProxyAddress = this.SecureProxyAddress;
			returnProxy.SecureProxyPort = this.SecureProxyPort;
			returnProxy.SocksProxyAddress = this.SocksProxyAddress;
			returnProxy.SocksProxyPort = this.SocksProxyPort;
			returnProxy.UseAutoConfigureScript = this.UseAutoConfigureScript;
			returnProxy.UseAutoConfigureScriptAddress = this.UseAutoConfigureScriptAddress;
			returnProxy.UseProxyServer = this.UseProxyServer;
			returnProxy.UseProxyServerAddress = this.UseProxyServerAddress;
			returnProxy.UseProxyServerPort = this.UseProxyServerPort;
			returnProxy.UseSameProxyServerForAllProtocols = this.UseSameProxyServerForAllProtocols;

			return returnProxy;
		}

		public static void DisableProxy()
		{
			modifyUseProxy(false);
		}

		public static void EnableProxy()
		{
			modifyUseProxy(true);
		}

		public static void modifyUseProxy(bool newValue)
		{
			Registry.SetValue(BaseKey,"ProxyEnable", Convert.ToInt32(newValue),RegistryValueKind.DWord);
		}

	}

}
