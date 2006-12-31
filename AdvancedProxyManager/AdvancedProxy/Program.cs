using System;
using System.Configuration;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fleischmann.advancedproxy
{
	static class Program
	{
		/// <summary>
		/// Copyright karl fleischmann 2006
		///
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Proxy aProxy = Proxy.GetCurrentProxyFromRegistry();
			List<Proxy> proxyList = new List<Proxy>();
			proxyList.Add(aProxy);
			Application.Run(new MainForm(proxyList));
		}

		//static List<Proxy> GetProxySettingsFromConfig()
		//{
		//    ConfigurationSettings.AppSettings.Get(
		//}
	}
}