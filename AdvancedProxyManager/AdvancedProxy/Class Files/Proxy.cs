using Microsoft.Win32;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;

namespace fleischmann.advancedproxy
{
	/// <summary>
	/// Copyright karl fleischmann 2006
	/// </summary>
	public class Proxy
	{
		const string BaseKey = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";

		private string _Name;
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		private string _Description;
		public string Description
		{
			get { return _Description; }
			set { _Description = value; }
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

		public Proxy()
		{
		}

		public static List<Proxy> GetAllAdvancedProxies()
		{
			List<Proxy> list = new List<Proxy>();
			return list;
			
		}

		public static bool SetAsCurrentProxy(Proxy theProxy)
		{
			return true;
		}

		public static Proxy GetCurrentProxyFromRegistry()
		{
			Proxy returnProxy = new Proxy();
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

				returnProxy.Name = "RegistryProxy";
				returnProxy.Description = "Copy of proxy information found in current registry keys";
			}

			return returnProxy;
		}

		public bool SetAsCurrentProxy()
		{
			return true;
		}

		public bool SaveInConfigFile()
		{
//			ConfigurationManager.AppSettings.Add("ProxySettings", "MyProxySettings");
			return true;
		}

		public Proxy Clone()
		{
			Proxy returnProxy = new Proxy();
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
			returnProxy.Description = this.Description;
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
