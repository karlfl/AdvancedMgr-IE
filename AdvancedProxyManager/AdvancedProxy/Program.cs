using System;
using System.Configuration;
using System.Collections.Generic;
using System.Windows.Forms;

using Fleischmann.AdvancedProxy.ProxyConfiguration;

namespace Fleischmann.AdvancedProxy
{
	static class Program
	{
		/// <summary>
		/// Copyright karl fleischmann 2006-2007
		///
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			List<ProxySetting> proxyList = new List<ProxySetting>();

			//Get all proxies defined in the config file.
			ProxyDefinitionSection section = (ProxyDefinitionSection)ConfigurationManager.GetSection("ProxyDefinition");
			if (section.ProxyDefinitions != null)
			{
				foreach (ProxyElement proxyElement in section.ProxyDefinitions)
				{
					proxyList.Add(new ProxySetting(proxyElement));
				}
			}
			
			Application.Run(new MainForm(proxyList));
		}
	}
}