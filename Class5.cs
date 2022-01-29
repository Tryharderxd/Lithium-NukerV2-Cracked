using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using LithiumCore;
using Veylib.CLIUI;

internal class Class5
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class6
	{
		public static readonly Class6 _003C_003E9 = new Class6();

		public static ThreadStart _003C_003E9__6_0;

		public static ThreadStart _003C_003E9__6_1;

		public static noret _003C_003E9__7_0;

		public static noret _003C_003E9__7_1;

		public static noret _003C_003E9__7_2;

		public static noret _003C_003E9__7_3;

		internal void method_0()
		{
			channels_0.Nuke();
		}

		internal void method_1()
		{
			roles_0.Nuke();
		}

		internal void method_2()
		{
			smethod_0();
		}

		internal void method_3()
		{
			smethod_0();
		}

		internal void method_4()
		{
			smethod_0();
		}

		internal void method_5()
		{
			smethod_0();
		}
	}

	[CompilerGenerated]
	private sealed class Class7
	{
		public string string_0;

		public int int_0;

		internal void method_0()
		{
			roles_0.Spam(string_0, int_0, ColorTranslator.FromHtml("#6B00FF"));
		}
	}

	[CompilerGenerated]
	private sealed class Class8
	{
		public bool bool_0;

		internal void method_0()
		{
			users_0.BanAll(bool_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class9
	{
		public string string_0;

		public int int_0;

		public bool bool_0;

		internal void method_0()
		{
			webhooks_0.Spam(GClass0.string_3, GClass0.string_4, string_0, int_0, bool_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class10
	{
		public string string_0;

		public string string_1;

		public int int_0;

		internal void method_0()
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			channels_0.Spam(string_0, (Type)Enum.Parse(typeof(Type), string_1), int_0);
		}
	}

	public static Core core_0 = Core.GetInstance();

	private static Channels channels_0;

	private static Webhooks webhooks_0;

	private static Users users_0;

	private static Roles roles_0;

	private static Bot bot_0 = new Bot();

	private static void smethod_0()
	{
		AsciiTable asciiTable = new AsciiTable(new AsciiTable.Properties
		{
			Colors = new AsciiTable.ColorProperties
			{
				RainbowDividers = true
			}
		});
		asciiTable.AddColumn($"Version - {GClass1.smethod_1()}");
		asciiTable.AddColumn($"Core version - {GClass1.smethod_1(typeof(Bot).Assembly)}");
		AsciiTable asciiTable2 = new AsciiTable(new AsciiTable.Properties
		{
			Colors = new AsciiTable.ColorProperties
			{
				RainbowDividers = true
			}
		});
		asciiTable2.AddColumn("1 - Webhook spam channels");
		asciiTable2.AddColumn("2 - Create channels");
		asciiTable2.AddColumn("3 - Delete channels");
		asciiTable2.AddRow("4 - Create roles", "5 - Delete roles", "6 - Ban members");
		core_0.Clear();
		asciiTable.WriteTable();
		asciiTable2.WriteTable();
		if (int.TryParse(core_0.ReadLine("Choice : "), out var result))
		{
			switch (result)
			{
			default:
				core_0.WriteLine("Invalid choice");
				core_0.Delay(2500);
				smethod_0();
				break;
			case 1:
				smethod_2();
				break;
			case 2:
				smethod_3();
				break;
			case 3:
				new Thread((ThreadStart)delegate
				{
					channels_0.Nuke();
				}).Start();
				break;
			case 4:
				smethod_4();
				break;
			case 5:
				new Thread((ThreadStart)delegate
				{
					roles_0.Nuke();
				}).Start();
				break;
			case 6:
				smethod_5();
				break;
			}
		}
		else
		{
			core_0.WriteLine("Invalid choice");
			core_0.Delay(2500);
			smethod_0();
		}
	}

	public static void smethod_1()
	{
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		string text;
		while (true)
		{
			core_0.Clear();
			Regex regex = new Regex("[\\w-]{24}.[\\w-]{6}.[\\w-]{27}");
			text = GClass0.string_2;
			if (text == null)
			{
				text = core_0.ReadLine("Bot token : ");
			}
			if (regex.Match(text).Length == 0)
			{
				core_0.WriteLine(Color.Red, "Input does not conform to token format.");
				core_0.Delay(2500);
				continue;
			}
			if (bot_0.TestToken(text))
			{
				break;
			}
			core_0.WriteLine(Color.Red, "Invalid bot token.");
			core_0.Delay(2500);
		}
		GClass0.string_2 = text;
		bool flag = GClass0.nullable_0.HasValue;
		long result;
		while (true)
		{
			core_0.Clear();
			if (!flag)
			{
				flag = long.TryParse(core_0.ReadLine("Guild ID : "), out result);
			}
			else
			{
				result = GClass0.nullable_0.Value;
			}
			if (flag)
			{
				if (bot_0.IsInGuild(GClass0.string_2, result))
				{
					break;
				}
				core_0.WriteLine(Color.Red, "Bot is not in guild.");
				core_0.Delay(2500);
			}
			else
			{
				core_0.WriteLine(Color.Red, "Guild ID couldn't be parsed.");
				core_0.Delay(2500);
			}
		}
		GClass0.nullable_0 = result;
		channels_0 = new Channels(GClass0.string_2, GClass0.nullable_0.Value, GClass0.int_0);
		webhooks_0 = new Webhooks(GClass0.string_2, GClass0.nullable_0.Value, GClass0.int_0);
		users_0 = new Users(GClass0.string_2, GClass0.nullable_0.Value, GClass0.int_0);
		roles_0 = new Roles(GClass0.string_2, GClass0.nullable_0.Value, GClass0.int_0);
		object obj = Class6._003C_003E9__7_0;
		if (obj == null)
		{
			noret val = delegate
			{
				smethod_0();
			};
			obj = (object)val;
			Class6._003C_003E9__7_0 = val;
		}
		Channels.add_Finished((noret)obj);
		object obj2 = Class6._003C_003E9__7_1;
		if (obj2 == null)
		{
			noret val2 = delegate
			{
				smethod_0();
			};
			obj2 = (object)val2;
			Class6._003C_003E9__7_1 = val2;
		}
		Webhooks.add_Finished((noret)obj2);
		object obj3 = Class6._003C_003E9__7_2;
		if (obj3 == null)
		{
			noret val3 = delegate
			{
				smethod_0();
			};
			obj3 = (object)val3;
			Class6._003C_003E9__7_2 = val3;
		}
		Users.add_Finished((noret)obj3);
		object obj4 = Class6._003C_003E9__7_3;
		if (obj4 == null)
		{
			noret val4 = delegate
			{
				smethod_0();
			};
			obj4 = (object)val4;
			Class6._003C_003E9__7_3 = val4;
		}
		Roles.add_Finished((noret)obj4);
		smethod_0();
	}

	private static void smethod_2()
	{
		string string_0 = core_0.ReadLine("Content : ");
		if (int.TryParse(core_0.ReadLine("Amount of messages per webhook : "), out var int_0))
		{
			string text = core_0.ReadLine("Reuse existing webhooks (causes long delay) : [y/N] ");
			bool bool_0 = true;
			if (text == "" || text.ToLower() == "n")
			{
				bool_0 = false;
			}
			if (string_0 == "")
			{
				string_0 = "@everyone discord.gg/lith";
			}
			new Thread((ThreadStart)delegate
			{
				webhooks_0.Spam(GClass0.string_3, GClass0.string_4, string_0, int_0, bool_0);
			}).Start();
		}
		else
		{
			core_0.WriteLine(Color.Red, "Failed to parse amount of messages to an int");
		}
	}

	private static void smethod_3()
	{
		string string_0 = core_0.ReadLine("Channel name : ");
		string string_1 = core_0.ReadLine("Type : [text, voice] ");
		if (int.TryParse(core_0.ReadLine("Amount : "), out var int_0))
		{
			if (string_1 == "")
			{
				string_1 = "text";
			}
			if (string_1.ToLower() != "text" && string_1.ToLower() != "voice")
			{
				core_0.WriteLine(Color.Red, "Invalid channel type");
				return;
			}
			string_1 = string_1.Substring(0, 1).ToUpper() + string_1.Substring(1).ToLower();
			if (string_0 == "")
			{
				string_0 = "ran by lithium";
			}
			new Thread((ThreadStart)delegate
			{
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				channels_0.Spam(string_0, (Type)Enum.Parse(typeof(Type), string_1), int_0);
			}).Start();
		}
		else
		{
			core_0.WriteLine(Color.Red, "Failed to parse amount to an int");
		}
	}

	private static void smethod_4()
	{
		string string_0 = core_0.ReadLine("Role name : ");
		if (!int.TryParse(core_0.ReadLine("Amount : "), out var int_0))
		{
			core_0.WriteLine(Color.Red, "Failed to parse amount to an int");
		}
		else
		{
			new Thread((ThreadStart)delegate
			{
				roles_0.Spam(string_0, int_0, ColorTranslator.FromHtml("#6B00FF"));
			}).Start();
		}
	}

	private static void smethod_5()
	{
		string text = core_0.ReadLine("Ban IDs : [y/N] ");
		bool bool_0;
		if (!(text == "") && !(text.ToLower() == "n"))
		{
			bool_0 = true;
		}
		else
		{
			bool_0 = false;
		}
		if (bool_0 && !File.Exists("ids.txt"))
		{
			new WebClient().DownloadFile("https://lithium.verlox.cc/app/ids.txt", "ids.txt");
		}
		new Thread((ThreadStart)delegate
		{
			users_0.BanAll(bool_0);
		}).Start();
	}
}
