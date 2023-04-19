using System;
namespace FlyOutDemo
{
	public class Constants
	{
        public static string LocalhostUrl = DeviceInfo.Platform == DevicePlatform.Android ? "10.0.2.2" : "localhost";
        public static string Scheme = "https"; // or http
        public static string Port = "443";
        public static string RestUrl = $"{Scheme}://api.coogoo.co.uk:{Port}/api/";
    }
}

