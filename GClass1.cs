using System;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;
using Veylib.Authentication;
using Veylib.CLIUI;

public class GClass1
{
	[CompilerGenerated]
	private static class Class12
	{
		public static CallSite<Func<CallSite, object, string, object>> callSite_0;

		public static CallSite<Func<CallSite, object, string, object>> callSite_1;

		public static CallSite<Func<CallSite, object, bool, object>> callSite_2;

		public static CallSite<Func<CallSite, Type, object, object>> callSite_3;

		public static CallSite<Func<CallSite, Encoding, object, object>> callSite_4;

		public static CallSite<Func<CallSite, object, byte[]>> callSite_5;

		public static CallSite<Func<CallSite, object, object>> callSite_6;

		public static CallSite<Func<CallSite, object, int>> callSite_7;
	}

	private static Core core_0 = Core.GetInstance();

	public static void smethod_0(Exception exception_0, bool bool_0 = true)
	{
		if (GClass0.bool_0)
		{
			return;
		}
		core_0.WriteLine("Creating exception report...");
		WebRequest webRequest = WebRequest.Create("https://verlox.cc/api/v2/auth/lithium/reporterror");
		webRequest.Method = "POST";
		webRequest.ContentType = "application/json";
		webRequest.Headers.Add("Authorization", User.CurrentUser.Token);
		webRequest.Headers.Add("HWID", Shared.HWID);
		dynamic val = new ExpandoObject();
		val.stacktrace = exception_0.StackTrace;
		val.error = exception_0.Message;
		val.auto = bool_0;
		byte[] array = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(val));
		webRequest.GetRequestStream().Write(array, 0, array.Length);
		try
		{
			dynamic val2 = JsonConvert.DeserializeObject(new StreamReader(webRequest.GetResponse().GetResponseStream()).ReadToEnd());
			if ((int)val2.code == 200)
			{
				core_0.WriteLine(Color.Lime, "Exception report successfully submitted");
			}
		}
		catch (Exception ex)
		{
			core_0.WriteLine(Color.Red, "Failed to send exception report: " + ex.Message);
		}
	}

	public static Version smethod_1(Assembly assembly_0 = null)
	{
		if (assembly_0 == null)
		{
			assembly_0 = Assembly.GetCallingAssembly();
		}
		return assembly_0.GetName().Version;
	}
}
