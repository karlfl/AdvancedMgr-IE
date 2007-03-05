using System;
using System.Diagnostics;
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
		public static void Main()
		{

			Process ThisProcess = Process.GetCurrentProcess();
			Process[] appProcesses = Process.GetProcessesByName(ThisProcess.ProcessName);

			//only proceed if not already running (counting this instance).
			if (appProcesses.Length == 1)
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
						ProxySetting newSetting = new ProxySetting(proxyElement);
						proxyList.Add(newSetting);
					}
				}


				if (proxyList.Count == 0)
				{
					DialogResult result = MessageBox.Show("You currently have no Proxy Settings defined.  \n\n Would you like to create an initial configuration based on your current proxy settings in Internet Explorer?", "Create Initial Proxy Set", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
					if (result == DialogResult.Yes)
					{
						ProxySetting currentRegistryProxy = ProxySetting.GetCurrentProxyFromInternetExplorer();
						ProxyNamePromptDialog dlgNamePrompt = new ProxyNamePromptDialog(proxyList);
						dlgNamePrompt.txtName.Text = currentRegistryProxy.Name;
						result = dlgNamePrompt.ShowDialog();
						if (result == DialogResult.OK)
						{
							currentRegistryProxy.Name = dlgNamePrompt.txtName.Text;
							currentRegistryProxy.SaveInConfigFile();
							proxyList.Add(currentRegistryProxy);
						}
					}
				}


				new MainForm(proxyList);
				Application.Run();
			}
		}
	}
}