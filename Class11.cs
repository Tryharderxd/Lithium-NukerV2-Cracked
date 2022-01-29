using System;
using System.Drawing;
using System.IO;
using System.Net;
using Microsoft.Win32;
using Veylib.Authentication;
using Veylib.CLIUI;

internal class Class11
{
	public static Core core_0 = Core.GetInstance();

	private static void smethod_0(string[] string_0)
	{
		for (int i = 0; i < string_0.Length; i++)
		{
			switch (string_0[i].ToLower())
			{
			case "--guild":
			{
				i++;
				if (!long.TryParse(string_0[i], out var result2))
				{
					core_0.WriteLine(Color.Red, "--guild argument value invalid");
				}
				GClass0.nullable_0 = result2;
				break;
			}
			case "--connection-limit":
			{
				i++;
				if (!int.TryParse(string_0[i], out var result3))
				{
					core_0.WriteLine(Color.Red, "--connection-limit argument value invalid");
				}
				GClass0.int_1 = result3;
				break;
			}
			default:
				core_0.WriteLine(Color.Red, "Invalid argument: " + string_0[i].ToLower());
				break;
			case "--local-core":
				GClass0.bool_1 = true;
				break;
			case "--threads":
			{
				i++;
				if (!int.TryParse(string_0[i], out var result))
				{
					core_0.WriteLine(Color.Red, "--threads argument value invalid");
				}
				GClass0.int_0 = result;
				break;
			}
			case "--token":
				i++;
				GClass0.string_2 = string_0[i];
				break;
			case "--debug":
				GClass0.bool_0 = true;
				break;
			}
		}
	}

	private static User.UserData smethod_1(string string_0, string string_1, string string_2 = null)
	{
		try
		{
			User.UserData userData = ((string_2 == null) ? User.Verify(string_0, string_1) : User.Verify(string_2));
			switch (userData.State)
			{
			case User.UserVerificationState.ValidCredentials:
			{
				if (!File.Exists("LithiumCore.dll"))
				{
					core_0.WriteLine(userData.Token);
					WebClient webClient = new WebClient();
					webClient.Headers.Add("Authorization", userData.Token);
					webClient.Headers.Add("HWID", Shared.HWID);
					if (!GClass0.bool_1)
					{
						webClient.DownloadFile("https://verlox.cc/api/v2/auth/lithium/download", "LithiumCore.dll");
					}
				}
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(GClass0.string_0);
				registryKey.SetValue("AccountToken", userData.Token);
				registryKey.Close();
				Class5.smethod_1();
				break;
			}
			case User.UserVerificationState.InvalidCredentials:
				core_0.WriteLine(Color.Red, "Invalid credentials");
				break;
			case User.UserVerificationState.ApplicationDisabled:
				core_0.WriteLine(Color.Red, "Application is disabled.");
				break;
			case User.UserVerificationState.AccountDisabled:
				core_0.WriteLine(Color.Red, "Account is disabled.");
				break;
			case User.UserVerificationState.InvalidHWID:
				core_0.WriteLine(Color.Red, "HWID invalid.");
				break;
			}
			return userData;
		}
		catch (WebException ex)
		{
			GClass1.smethod_0(ex);
			core_0.WriteLine("WebException! ", Color.Red, new StreamReader(ex.Response.GetResponseStream()).ReadToEnd().Replace("\n", " "));
		}
		catch (Exception ex2)
		{
			GClass1.smethod_0(ex2);
			core_0.WriteLine(Color.Red, "Error logging in: " + ex2.Message);
		}
		return null;
	}

	private static void Main(string[] args)
	{
		Shared.AppID = 2;
		Shared.APIUrl = "https://verlox.cc/api/v2";
		smethod_0(args);
		StartupProperties startProperties = new StartupProperties
		{
			MOTD = (GClass0.bool_0 ? "Debug build | auto error reporting disabled." : "suck a fat cock"),
			ColorRotation = 260,
			SilentStart = true,
			LogoString = GClass0.string_1,
			DebugMode = GClass0.bool_0,
			Author = new StartupAuthorProperties
			{
				Url = "verlox.cc & russianheavy.xyz",
				Name = "verlox & russian heavy"
			},
			Title = new StartupConsoleTitleProperties
			{
				Text = "Lithium Nuker V2",
				Status = "Authorization required"
			}
		};
		core_0.Start(startProperties);
		Vars.VarData varData = Vars.Get("loader_version", -1);
		if (varData.State != Vars.VarState.Success)
		{
			core_0.WriteLine(new MessageProperties
			{
				Label = new MessagePropertyLabel
				{
					Text = "fail"
				}
			}, "Failed to check version, press any key to close");
			Console.ReadKey();
			return;
		}
		if (Version.Parse(varData.Value) > GClass1.smethod_1())
		{
			core_0.WriteLine(new MessageProperties
			{
				Label = new MessagePropertyLabel
				{
					Text = "fail"
				}
			}, "This client is outdated, download a new client from the Discord, press any key to close");
			Console.ReadKey();
			return;
		}
		ServicePointManager.DefaultConnectionLimit = GClass0.int_1;
		ServicePointManager.Expect100Continue = false;
		while (true)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(GClass0.string_0);
			if (registryKey != null)
			{
				string text = (string)registryKey.GetValue("AccountToken");
				registryKey.Close();
				if (text != null)
				{
					User.UserData userData = smethod_1(null, null, text);
					if (userData == null)
					{
						continue;
					}
					if (userData.State == User.UserVerificationState.ValidCredentials)
					{
						break;
					}
				}
			}
			while (true)
			{
				string string_ = core_0.ReadLine("Username : ");
				string string_2 = core_0.ReadLineProtected("Password : ");
				smethod_1(string_, string_2);
			}
		}
	}
}
