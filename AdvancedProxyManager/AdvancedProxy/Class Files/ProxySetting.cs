// Project: AdvancedProxy, File: ProxySetting.cs
// Namespace: Fleischmann.AdvancedProxy, Class: ProxySetting
// Path: D:\My Documents\Visual Studio 2005\Projects\AdvancedProxy\AdvancedProxy\Class Files, Author: rzd7jx
// Code lines: 475, Size of file: 15.49 KB
// Creation date: 12/30/2006 11:39 AM
// Last modified: 1/12/2007 7:28 AM
// Generated with Commenter by abi.exDream.com

using Microsoft.Win32;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;

using Fleischmann.AdvancedProxy.ProxyConfiguration;

namespace Fleischmann.AdvancedProxy
{
	/// <summary>
	/// Copyright karl fleischmann 2006-2009
	/// </summary>
	[Serializable]
	public class ProxySetting
	{
		#region Properties
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

		private string _HTTPProxyPort = "";
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

		private string _SecureProxyPort = "";
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

		private string _FTPProxyPort = "";
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

		private string _GopherProxyPort = "";
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

		private string _SocksProxyPort = "";
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

		#endregion

		#region Constructors
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
			this.UseProxyServerPort = configElement.UseProxyServerPort;
			this.BypassProxyForLocalAddress = configElement.BypassProxyForLocalAddress;
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
		
		#endregion

		#region Get List All Advanced Proxy Settings
		public static List<ProxySetting> GetAllAdvancedProxies()
		{
			List<ProxySetting> list = new List<ProxySetting>();
			return list;

		}
		#endregion

		#region Get Current Proxy Settings From Registry
		public static ProxySetting GetCurrentProxyFromInternetExplorer()
		{
			ProxySetting returnProxy = new ProxySetting();
			returnProxy.AutoDetectSettings = ProxySetting.GetCurrentActiveAutoDetectProxy();
			returnProxy.UseAutoConfigureScript = ProxySetting.GetCurrentActiveAutoConfigProxy();
			returnProxy.UseAutoConfigureScriptAddress = ProxySetting.GetCurrentActiveAutoConfigURL();
			returnProxy.UseProxyServer = ProxySetting.GetCurrentActiveUseProxy();

			string proxyServerString = ProxySetting.GetCurrentActiveProxyServerURLs();
			if (!string.IsNullOrEmpty(proxyServerString.Trim()))
			{
				string[] proxyServerList = proxyServerString.Split(';');
				if (proxyServerList.Length > 1)
				{
					returnProxy.UseSameProxyServerForAllProtocols = false;
					foreach (string aProxyServer in proxyServerList)
					{
						string[] proxyServer = aProxyServer.Split('=');
						string type = proxyServer[0];
						string[] serverAddressAndPort = proxyServer[1].Split(':');
						switch (type)
						{
							case ("http"):
								returnProxy.HTTPProxyAddress = serverAddressAndPort[0];
								returnProxy.HTTPProxyPort = serverAddressAndPort[1];
								break;
							case ("https"):
								returnProxy.SecureProxyAddress = serverAddressAndPort[0];
								returnProxy.SecureProxyPort = serverAddressAndPort[1];
								break;
							case ("ftp"):
								returnProxy.FTPProxyAddress = serverAddressAndPort[0];
								returnProxy.FTPProxyPort = serverAddressAndPort[1];
								break;
							case ("gopher"):
								returnProxy.GopherProxyAddress = serverAddressAndPort[0];
								returnProxy.GopherProxyPort = serverAddressAndPort[1];
								break;
							case ("socks"):
								returnProxy.SocksProxyAddress = serverAddressAndPort[0];
								returnProxy.SocksProxyPort = serverAddressAndPort[1];
								break;
						}
					}
				}
				else
				{
					returnProxy.UseSameProxyServerForAllProtocols = true;
					string[] serverAddressAndPort = proxyServerString.Split(':');
					returnProxy.UseProxyServerAddress = serverAddressAndPort[0];
					returnProxy.UseProxyServerPort = serverAddressAndPort[1];
				}

				returnProxy.Name = "Initial Proxy Settings";
			}

			returnProxy.ExcludeAddressesFromProxy = ProxySetting.GetCurrentActiveBypassProxy();
			if (returnProxy.ExcludeAddressesFromProxy.EndsWith("<local>"))
			{
				returnProxy.BypassProxyForLocalAddress = true;
				returnProxy.ExcludeAddressesFromProxy = returnProxy.ExcludeAddressesFromProxy.Substring(0, returnProxy.ExcludeAddressesFromProxy.Length - 8);
			}
			else
			{
				returnProxy.BypassProxyForLocalAddress = false;
			}

			return returnProxy;
		}
		#endregion

		#region Update Config File Methods
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
			UpdateProxyAddressAndPort(this.SecureProxyAddress, this.SecureProxyPort, "HTTPS", configElement);
			UpdateProxyAddressAndPort(this.FTPProxyAddress, this.FTPProxyPort, "FTP", configElement);
			UpdateProxyAddressAndPort(this.GopherProxyAddress, this.GopherProxyPort, "Gopher", configElement);
			UpdateProxyAddressAndPort(this.SocksProxyAddress, this.SocksProxyPort, "Socks", configElement);

			myConfig.Save();

			return true;
		}

		public bool DeleteFromConfig()
		{
			//Remove this config element
			Configuration myConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			ProxyDefinitionSection mySection = (ProxyDefinitionSection)myConfig.GetSection("ProxyDefinition");
			mySection.ProxyDefinitions.Remove(this.Name);
			myConfig.Save();

			return true;
		}

		private static void UpdateProxyAddressAndPort(string ProxyAddress, string ProxyPort, string ProxyProtocol, ProxyElement configElement)
		{
			if (ProxyAddress != null &&
				!string.IsNullOrEmpty(ProxyAddress))
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
		#endregion

		#region Clone (Copy Class)
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
		#endregion

		#region Copy Existing Proxy (Set Values on current class to new class)
		public void Copy(ProxySetting newValues)
		{
			this.AutoDetectSettings = newValues.AutoDetectSettings;
			this.BypassProxyForLocalAddress = newValues.BypassProxyForLocalAddress;
			this.ExcludeAddressesFromProxy = newValues.ExcludeAddressesFromProxy;
			this.FTPProxyAddress = newValues.FTPProxyAddress;
			this.FTPProxyPort = newValues.FTPProxyPort;
			this.GopherProxyAddress = newValues.GopherProxyAddress;
			this.GopherProxyPort = newValues.GopherProxyPort;
			this.HTTPProxyAddress = newValues.HTTPProxyAddress;
			this.HTTPProxyPort = newValues.HTTPProxyPort;
			this.Name = newValues.Name;
			this.SecureProxyAddress = newValues.SecureProxyAddress;
			this.SecureProxyPort = newValues.SecureProxyPort;
			this.SocksProxyAddress = newValues.SocksProxyAddress;
			this.SocksProxyPort = newValues.SocksProxyPort;
			this.UseAutoConfigureScript = newValues.UseAutoConfigureScript;
			this.UseAutoConfigureScriptAddress = newValues.UseAutoConfigureScriptAddress;
			this.UseProxyServer = newValues.UseProxyServer;
			this.UseProxyServerAddress = newValues.UseProxyServerAddress;
			this.UseProxyServerPort = newValues.UseProxyServerPort;
			this.UseSameProxyServerForAllProtocols = newValues.UseSameProxyServerForAllProtocols;
		}
		#endregion

		#region Set As Current Proxy
		public bool SetAsCurrentProxy()
		{
			StringBuilder proxyString = new StringBuilder();
			if (!string.IsNullOrEmpty(UseProxyServerAddress))
			{
				buildProxyString(proxyString, "", UseProxyServerAddress, UseProxyServerPort);
			}
			else
			{
				if (!string.IsNullOrEmpty(HTTPProxyAddress))
				{
					buildProxyString(proxyString, "http", HTTPProxyAddress, HTTPProxyPort);
				}
				if (!UseSameProxyServerForAllProtocols)
				{
					if (!string.IsNullOrEmpty(SecureProxyAddress))
					{
						buildProxyString(proxyString, "https", SecureProxyAddress, SecureProxyPort);
					}
					if (!string.IsNullOrEmpty(FTPProxyAddress))
					{
						buildProxyString(proxyString, "ftp", FTPProxyAddress, FTPProxyPort);
					}
					if (!string.IsNullOrEmpty(GopherProxyAddress))
					{
						buildProxyString(proxyString, "gopher", GopherProxyAddress, GopherProxyPort);
					}
					if (!string.IsNullOrEmpty(SocksProxyAddress))
					{
						buildProxyString(proxyString, "socks", SocksProxyAddress, SocksProxyPort);
					}
				}
			}

			string excludeAddress = this.ExcludeAddressesFromProxy;
			if (BypassProxyForLocalAddress)
			{
				excludeAddress += ";<local>";
			}

			return WinInetInterop.SetInternetProxy(this.UseProxyServer, proxyString.ToString(), excludeAddress,
												this.AutoDetectSettings,this.UseAutoConfigureScript,this.UseAutoConfigureScriptAddress);
		}

		private static void buildProxyString(StringBuilder proxyString, string proxyType, string proxyAddress, string proxyPort)
		{
			if (proxyString.Length > 0)
			{
				proxyString.Append(";");
			}
			if (!string.IsNullOrEmpty(proxyType))
			{
				proxyString.Append(proxyType);
				proxyString.Append("=");
			}
			proxyString.Append(proxyAddress).Append(":").Append(proxyPort);
		}
		#endregion

		#region Static Utility Methods for Current Active Proxy Settings
		#region Get/Modify Current Active Use Proxy Flag
		public static void ModifyCurrentActiveUseProxy(bool newValue)
		{
			WinInetInterop.SwitchUseProxy(newValue);
		}

		public static bool GetCurrentActiveUseProxy()
		{
			return WinInetInterop.IsUseProxy();
		}
		#endregion

		#region Get/Modify Current Active Auto Detect Proxy Flag
		public static void ModifyCurrentActiveAutoDetectProxy(bool newValue)
		{
			WinInetInterop.SwitchAutoDetectProxy(newValue);
		}

		public static bool GetCurrentActiveAutoDetectProxy()
		{
			return WinInetInterop.IsAutoDetectProxy();
		}
		#endregion

		#region Get/Modify Current Active Auto Config Proxy Flag
		public static void ModifyCurrentActiveAutoConfigProxy(bool newValue)
		{
			WinInetInterop.SwitchAutoConfigProxy(newValue);
		}

		public static void ModifyCurrentActiveAutoConfigProxyURL(string autoConfigURL)
		{
			WinInetInterop.SetAutoConfigURL(autoConfigURL);
		}

		public static bool GetCurrentActiveAutoConfigProxy()
		{
			return WinInetInterop.IsAutoConfigProxy();
		}
		#endregion

		#region Get Any Current Active Proxy Set
		public static bool AnyCurrentActiveProxySet()
		{
			return WinInetInterop.IsAnyProxy();
		}
		#endregion

		#region Get Current Active Auto Config Proxy URL
		public static string GetCurrentActiveAutoConfigURL()
		{
			return WinInetInterop.GetAutoConfigURL();
		}
		#endregion

		#region Get Current Active Proxy Server URLs
		public static string GetCurrentActiveProxyServerURLs()
		{
			return WinInetInterop.GetProxyServerURL();
		}
		#endregion

		#region Get Current Active Bypass Proxy 
		public static string GetCurrentActiveBypassProxy()
		{
			return WinInetInterop.GetBypassProxy();
		}
		#endregion

		#endregion
	}

}
