// Project: AdvancedProxy, File: APIWrapper.cs
// Namespace: Fleischmann.AdvancedProxy, Class: APIWrapper
// Path: D:\My Documents\Visual Studio 2005\Projects\AdvancedProxy\AdvancedProxy\Class Files\Utility, Author: rzd7jx
// Code lines: 65, Size of file: 2.13 KB
// Creation date: 1/15/2007 2:10 PM
// Last modified: 1/15/2007 5:57 PM
// Generated with Commenter by abi.exDream.com

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Fleischmann.AdvancedProxy
{
	public struct INTERNET_PROXY_INFO
	{
		public int dwAccessType;
		public IntPtr proxy;
		public IntPtr proxyBypass;
	};

	class APIWrapper
	{
		public const int INTERNET_OPTION_PROXY = 38;
		public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
		public const int INTERNET_OPTION_PROXY_SETTINGS_CHANGED = 95;

		public const int INTERNET_OPEN_TYPE_PRECONFIG = 0;
		public const int INTERNET_OPEN_TYPE_DIRECT = 1;
		public const int INTERNET_OPEN_TYPE_PROXY = 3;

		[DllImport("inetcpl.cpl", SetLastError = true)]
		public static extern int LaunchInternetControlPanel(IntPtr hWnd);

		[DllImport("wininet.dll", SetLastError = true)]
		public static extern bool InternetQueryOption(
			IntPtr hInternet,			//Handle on which to query information.
			int dwOption,				//Internet option to be queried.
			IntPtr lpBuffer,			//Pointer to a buffer that receives the option setting.
			ref int lpdwBufferLength	//Pointer to a variable that contains the size of lpBuffer, in bytes.
		);

		[DllImport("wininet.dll", SetLastError = true)]
		public static extern bool InternetSetOption(
			IntPtr hInternet,		//Handle on which to query information.
			int dwOption,			//Internet option to be queried.
			IntPtr lpBuffer,		//Pointer to a buffer that contains the option setting.
			int lpdwBufferLength	//Pointer to a variable that contains the size of lpBuffer, in bytes.
		);




		public static void SaveProxySettings(bool enableProxy, string proxyServerString, string proxyBypass)
		{
			INTERNET_PROXY_INFO struct_IPI;

			// Filling in structure 
			if (enableProxy)
			{
				struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_PROXY;
			}
			else
			{
				struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_DIRECT;
			}

			struct_IPI.proxy = Marshal.StringToHGlobalAnsi(proxyServerString);
			struct_IPI.proxyBypass = Marshal.StringToHGlobalAnsi(proxyBypass);

			// Allocating memory 
			IntPtr intptrStruct = Marshal.AllocCoTaskMem(Marshal.SizeOf(struct_IPI));

			// Converting structure to IntPtr 
			Marshal.StructureToPtr(struct_IPI, intptrStruct, true);

			bool iReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY, intptrStruct, Marshal.SizeOf(struct_IPI));
		}

		public static void InternetOptionSettingsChanged()
		{
			bool iReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
			if (iReturn == false)
			{
				int test = 1;

			}
		}
	}

	

}
