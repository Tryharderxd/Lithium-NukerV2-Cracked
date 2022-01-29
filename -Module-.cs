using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002BC8 File Offset: 0x00000DC8
	unsafe static <Module>()
	{
		uint num = 400U;
		uint[] array = new uint[]
		{
			3804535351U, 618017319U, 1019279883U, 885536258U, 655637768U, 307666833U, 2447705730U, 2619599248U, 1162958289U, 1669738502U,
			1948915435U, 755330197U, 2815556887U, 2530835700U, 2737129413U, 1067119647U, 1193285228U, 1906809590U, 3238273408U, 283225280U,
			1210725237U, 2872941439U, 3540963317U, 3357665057U, 745529411U, 3335500352U, 2469736563U, 3896838435U, 2560085609U, 3816702775U,
			2462768628U, 4154431734U, 1806811092U, 2989783821U, 1269053302U, 1263548854U, 2707040495U, 2905140417U, 2920319583U, 2701184486U,
			2469509596U, 3207035765U, 837752872U, 1258659083U, 4056744235U, 4125681284U, 1255890765U, 3898098684U, 1553942063U, 655297716U,
			480388610U, 4264235530U, 81391020U, 2136883188U, 3633190915U, 1003510985U, 3787291525U, 548493870U, 3692973602U, 371554658U,
			520391638U, 1366676127U, 1311833038U, 1923852073U, 4045048987U, 765043825U, 3957313385U, 2141413024U, 1071222110U, 2508709965U,
			3478213507U, 2156444332U, 2659561761U, 4161510081U, 1902599032U, 1174804207U, 23684904U, 378826681U, 2978491805U, 1210301887U,
			3078404175U, 1028095873U, 1847493278U, 1956253596U, 63560134U, 843557769U, 3369541282U, 4065071879U, 2838298965U, 2329474171U,
			26669822U, 3705184984U, 2572942037U, 1654847343U, 4229110265U, 2456645602U, 500293157U, 1984054021U, 1717736908U, 3994891637U,
			2199556699U, 978244793U, 2062964566U, 2087699662U, 3810283598U, 659550114U, 1207630665U, 1103742483U, 415206601U, 124335678U,
			1119170405U, 29237409U, 1644468701U, 3938563654U, 202762789U, 2828335060U, 3030047561U, 2565841433U, 940185959U, 1588667898U,
			399764236U, 2969487248U, 384876600U, 4116771269U, 1222853107U, 1218754035U, 1664034366U, 1309356905U, 1142773225U, 686167137U,
			4204775811U, 3219288278U, 973232073U, 1859346217U, 4161078750U, 4256737341U, 3102954591U, 2318588796U, 3548632290U, 3335099022U,
			2767909942U, 1203814870U, 394244676U, 611688579U, 2431227500U, 2455918235U, 1218193769U, 4031177458U, 3371876728U, 2926657115U,
			4099707554U, 103067502U, 3911548406U, 3748477722U, 3536275366U, 2401309563U, 972148323U, 2548454375U, 2873491858U, 4292257048U,
			401134292U, 4260450234U, 266765894U, 220994706U, 1193107169U, 2236189672U, 2926541729U, 564451530U, 590668308U, 3200812230U,
			4216476201U, 3985709021U, 4265622404U, 2656444175U, 3982235692U, 776565541U, 365063995U, 799415345U, 3740113596U, 530323049U,
			1802163506U, 1531729222U, 3843927342U, 1149341108U, 1693768863U, 628183611U, 473831358U, 2015941036U, 3786501099U, 3471032106U,
			2019691389U, 3515001084U, 4147240570U, 1405914828U, 1065309333U, 2980922271U, 1803143582U, 1853697351U, 4158781211U, 2004375752U,
			1328357269U, 1036000372U, 1022679275U, 2314290637U, 1635085885U, 253798888U, 2345693954U, 2390901884U, 875523092U, 3924208540U,
			2007622246U, 2699348180U, 793707021U, 2737184209U, 223991693U, 1397859293U, 1325659633U, 3305592415U, 1535241798U, 2624153305U,
			4137747278U, 2945194498U, 2088990767U, 1450239664U, 1002051146U, 3005208134U, 264501241U, 2896974373U, 3874846666U, 808216496U,
			3268260812U, 152547069U, 1728804180U, 2160329936U, 2485542132U, 2161555203U, 74819697U, 2461569441U, 3685626253U, 4086153395U,
			3126231500U, 1804817934U, 943886470U, 3764011918U, 941615675U, 4112558510U, 60816050U, 931148505U, 3573947497U, 3324675723U,
			2713571426U, 1896391212U, 1692292395U, 155132582U, 341045751U, 3241359538U, 1760790459U, 2655458032U, 4051925426U, 475440818U,
			2422239985U, 3472050387U, 3104466031U, 2054654420U, 3511299807U, 1687116922U, 2141866562U, 699583480U, 2345273569U, 1890939668U,
			3936603085U, 3125313761U, 547254858U, 1676919249U, 732850240U, 699293287U, 2700177887U, 3638277551U, 4145910355U, 3743672647U,
			117149760U, 3574211547U, 2880703323U, 3989450836U, 1776704668U, 1728954915U, 2143323736U, 1999344506U, 4093244081U, 989633875U,
			1010060705U, 1364639199U, 2110038486U, 4164479999U, 2599977693U, 2460077514U, 1603247659U, 4193880530U, 3569240673U, 2651296783U,
			2483648440U, 4220038421U, 1017049119U, 131624175U, 3650686146U, 2351193428U, 4269170090U, 846270686U, 1813502004U, 3863057510U,
			4011848527U, 557391841U, 2365526017U, 412507242U, 1845337789U, 367508741U, 1194812573U, 1280076566U, 708845044U, 2838810315U,
			328919374U, 2424415129U, 2742154809U, 3898467818U, 2156098672U, 2345088915U, 497018303U, 7493520U, 1542849082U, 2763321847U,
			893233634U, 1308374322U, 3798190317U, 3824512942U, 2724509092U, 2721462358U, 3386871840U, 1091560055U, 3442445649U, 2058990476U,
			902771142U, 1697410303U, 3794936885U, 3483905112U, 1416766029U, 1804963397U, 2980235260U, 1409172770U, 905603202U, 705600883U,
			2781206654U, 3006899555U, 571422735U, 2735662246U, 1689106643U, 2559395228U, 1851888457U, 1374327537U, 1181809692U, 3941549560U,
			3580459763U, 1390650014U, 3921515653U, 3887330567U, 2593370784U, 149104640U, 4177526699U, 3493978931U, 310216313U, 2167388297U,
			186064637U, 2973275665U, 1386155340U, 4229906211U, 1592452592U, 4179175512U, 1465303675U, 2897528659U, 867256931U, 1533170621U,
			2559964578U, 2287384395U, 608851088U, 1407114758U, 489948421U, 542360538U, 186112085U, 2973275665U, 1386155340U, 4229906211U,
			1592452592U, 4179175512U, 1465303675U, 2897528659U, 867256931U, 1533170621U, 2559964578U, 2287384395U, 608851088U, 1407114758U
		};
		uint[] array2 = new uint[16];
		uint num2 = 2932766337U;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 12;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4U];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			array3[0] = array3[0] ^ array2[0];
			array3[1] = array3[1] ^ array2[1];
			array3[2] = array3[2] ^ array2[2];
			array3[3] = array3[3] ^ array2[3];
			array3[4] = array3[4] ^ array2[4];
			array3[5] = array3[5] ^ array2[5];
			array3[6] = array3[6] ^ array2[6];
			array3[7] = array3[7] ^ array2[7];
			array3[8] = array3[8] ^ array2[8];
			array3[9] = array3[9] ^ array2[9];
			array3[10] = array3[10] ^ array2[10];
			array3[11] = array3[11] ^ array2[11];
			array3[12] = array3[12] ^ array2[12];
			array3[13] = array3[13] ^ array2[13];
			array3[14] = array3[14] ^ array2[14];
			array3[15] = array3[15] ^ array2[15];
			for (int k = 0; k < 16; k++)
			{
				uint num5 = array3[k];
				array4[num4++] = (byte)num5;
				array4[num4++] = (byte)(num5 >> 8);
				array4[num4++] = (byte)(num5 >> 16);
				array4[num4++] = (byte)(num5 >> 24);
				array2[k] ^= num5;
			}
			num3 += 16;
		}
		<Module>.byte_0 = <Module>.smethod_1(array4);
		Module module = typeof(<Module>).Module;
		byte* ptr = (byte*)(void*)Marshal.GetHINSTANCE(module);
		byte* ptr2 = ptr + 60;
		ptr2 = ptr + *(uint*)ptr2;
		ptr2 += 6;
		ushort num6 = *(ushort*)ptr2;
		ptr2 += 14;
		ushort num7 = *(ushort*)ptr2;
		ptr2 = ptr2 + 4 + num7;
		byte* ptr3 = stackalloc byte[(UIntPtr)11];
		MethodInfo method;
		if (module.FullyQualifiedName[0] == '<')
		{
			uint num8 = *(uint*)(ptr2 - 16);
			uint num9 = *(uint*)(ptr2 - 120);
			uint[] array5 = new uint[(int)num6];
			uint[] array6 = new uint[(int)num6];
			uint[] array7 = new uint[(int)num6];
			for (int l = 0; l < (int)num6; l++)
			{
				<Module>.VirtualProtect(ptr2, 8, 64U, ref method);
				Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr2), 8);
				array5[l] = *(uint*)(ptr2 + 12);
				array6[l] = *(uint*)(ptr2 + 8);
				array7[l] = *(uint*)(ptr2 + 20);
				ptr2 += 40;
			}
			if (num9 != 0U)
			{
				for (int m = 0; m < (int)num6; m++)
				{
					if (array5[m] <= num9 && num9 < array5[m] + array6[m])
					{
						num9 = num9 - array5[m] + array7[m];
						IL_551:
						byte* ptr4 = ptr + num9;
						uint num10 = *(uint*)ptr4;
						for (int n = 0; n < (int)num6; n++)
						{
							if (array5[n] <= num10 && num10 < array5[n] + array6[n])
							{
								num10 = num10 - array5[n] + array7[n];
								break;
							}
						}
						byte* ptr5 = ptr + num10;
						uint num11 = *(uint*)(ptr4 + 12);
						for (int num12 = 0; num12 < (int)num6; num12++)
						{
							if (array5[num12] <= num11 && num11 < array5[num12] + array6[num12])
							{
								num11 = num11 - array5[num12] + array7[num12];
								IL_5E4:
								uint num13 = *(uint*)ptr5 + 2U;
								for (int num14 = 0; num14 < (int)num6; num14++)
								{
									if (array5[num14] <= num13 && num13 < array5[num14] + array6[num14])
									{
										num13 = num13 - array5[num14] + array7[num14];
										IL_626:
										<Module>.VirtualProtect(ptr + num11, 11, 64U, ref method);
										*(int*)ptr3 = 1818522734;
										*(int*)(ptr3 + 4) = 1818504812;
										*(short*)(ptr3 + (IntPtr)4 * 2) = 108;
										ptr3[10] = 0;
										for (int num15 = 0; num15 < 11; num15++)
										{
											(ptr + num11)[num15] = ptr3[num15];
										}
										<Module>.VirtualProtect(ptr + num13, 11, 64U, ref method);
										*(int*)ptr3 = 1866691662;
										*(int*)(ptr3 + 4) = 1852404846;
										*(short*)(ptr3 + (IntPtr)4 * 2) = 25973;
										ptr3[10] = 0;
										for (int num16 = 0; num16 < 11; num16++)
										{
											(ptr + num13)[num16] = ptr3[num16];
										}
										goto IL_6D5;
									}
								}
								goto IL_626;
							}
						}
						goto IL_5E4;
					}
				}
				goto IL_551;
			}
			IL_6D5:
			for (int num17 = 0; num17 < (int)num6; num17++)
			{
				if (array5[num17] <= num8 && num8 < array5[num17] + array6[num17])
				{
					num8 = num8 - array5[num17] + array7[num17];
					IL_710:
					byte* ptr6 = ptr + num8;
					<Module>.VirtualProtect(ptr6, 72, 64U, ref method);
					uint num18 = *(uint*)(ptr6 + 8);
					for (int num19 = 0; num19 < (int)num6; num19++)
					{
						if (array5[num19] <= num18 && num18 < array5[num19] + array6[num19])
						{
							num18 = num18 - array5[num19] + array7[num19];
							IL_768:
							*(int*)ptr6 = 0;
							*(int*)(ptr6 + 4) = 0;
							*(int*)(ptr6 + (IntPtr)2 * 4) = 0;
							*(int*)(ptr6 + (IntPtr)3 * 4) = 0;
							byte* ptr7 = ptr + num18;
							<Module>.VirtualProtect(ptr7, 4, 64U, ref method);
							*(int*)ptr7 = 0;
							ptr7 += 12;
							ptr7 += *(uint*)ptr7;
							ptr7 = (ptr7 + 7L) & -4L;
							ptr7 += 2;
							ushort num20 = (ushort)(*ptr7);
							ptr7 += 2;
							int num21 = 0;
							IL_86B:
							while (num21 < (int)num20)
							{
								<Module>.VirtualProtect(ptr7, 8, 64U, ref method);
								ptr7 += 4;
								ptr7 += 4;
								int num22 = 0;
								while (num22 < 8)
								{
									<Module>.VirtualProtect(ptr7, 4, 64U, ref method);
									*ptr7 = 0;
									ptr7++;
									if (*ptr7 != 0)
									{
										*ptr7 = 0;
										ptr7++;
										if (*ptr7 != 0)
										{
											*ptr7 = 0;
											ptr7++;
											if (*ptr7 != 0)
											{
												*ptr7 = 0;
												ptr7++;
												num22++;
												continue;
											}
											ptr7++;
										}
										else
										{
											ptr7 += 2;
										}
									}
									else
									{
										ptr7 += 3;
									}
									IL_865:
									num21++;
									goto IL_86B;
								}
								goto IL_865;
							}
							goto IL_874;
						}
					}
					goto IL_768;
				}
			}
			goto IL_710;
		}
		byte* ptr8 = ptr + *(uint*)(ptr2 - 16);
		if (*(uint*)(ptr2 - 120) != 0U)
		{
			byte* ptr9 = ptr + *(uint*)(ptr2 - 120);
			byte* ptr10 = ptr + *(uint*)ptr9;
			byte* ptr11 = ptr + *(uint*)(ptr9 + 12);
			byte* ptr12 = ptr + *(uint*)ptr10 + 2;
			<Module>.VirtualProtect(ptr11, 11, 64U, ref method);
			*(int*)ptr3 = 1818522734;
			*(int*)(ptr3 + 4) = 1818504812;
			*(short*)(ptr3 + (IntPtr)4 * 2) = 108;
			ptr3[10] = 0;
			for (int num23 = 0; num23 < 11; num23++)
			{
				ptr11[num23] = ptr3[num23];
			}
			<Module>.VirtualProtect(ptr12, 11, 64U, ref method);
			*(int*)ptr3 = 1866691662;
			*(int*)(ptr3 + 4) = 1852404846;
			*(short*)(ptr3 + (IntPtr)4 * 2) = 25973;
			ptr3[10] = 0;
			for (int num24 = 0; num24 < 11; num24++)
			{
				ptr12[num24] = ptr3[num24];
			}
		}
		for (int num25 = 0; num25 < (int)num6; num25++)
		{
			<Module>.VirtualProtect(ptr2, 8, 64U, ref method);
			Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr2), 8);
			ptr2 += 40;
		}
		<Module>.VirtualProtect(ptr8, 72, 64U, ref method);
		byte* ptr13 = ptr + *(uint*)(ptr8 + 8);
		*(int*)ptr8 = 0;
		*(int*)(ptr8 + 4) = 0;
		*(int*)(ptr8 + (IntPtr)2 * 4) = 0;
		*(int*)(ptr8 + (IntPtr)3 * 4) = 0;
		<Module>.VirtualProtect(ptr13, 4, 64U, ref method);
		*(int*)ptr13 = 0;
		ptr13 += 12;
		ptr13 += *(uint*)ptr13;
		ptr13 = (ptr13 + 7L) & -4L;
		ptr13 += 2;
		ushort num26 = (ushort)(*ptr13);
		ptr13 += 2;
		int num27 = 0;
		IL_47D:
		while (num27 < (int)num26)
		{
			<Module>.VirtualProtect(ptr13, 8, 64U, ref method);
			ptr13 += 4;
			ptr13 += 4;
			int num28 = 0;
			while (num28 < 8)
			{
				<Module>.VirtualProtect(ptr13, 4, 64U, ref method);
				*ptr13 = 0;
				ptr13++;
				if (*ptr13 != 0)
				{
					*ptr13 = 0;
					ptr13++;
					if (*ptr13 != 0)
					{
						*ptr13 = 0;
						ptr13++;
						if (*ptr13 != 0)
						{
							*ptr13 = 0;
							ptr13++;
							num28++;
							continue;
						}
						ptr13++;
					}
					else
					{
						ptr13 += 2;
					}
				}
				else
				{
					ptr13 += 3;
				}
				IL_477:
				num27++;
				goto IL_47D;
			}
			goto IL_477;
		}
		IL_874:
		method = typeof(Environment).GetMethod("GetEnvironmentVariable", new Type[] { typeof(string) });
		if (method != null && "1".Equals(method.Invoke(null, new object[] { "COR_ENABLE_PROFILING" })))
		{
			Environment.FailFast(null);
		}
		new Thread(new ParameterizedThreadStart(<Module>.smethod_0))
		{
			IsBackground = true
		}.Start(null);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000034BC File Offset: 0x000016BC
	private static void smethod_0(object object_0)
	{
		Thread thread;
		if ((thread = object_0 as Thread) == null)
		{
			thread = new Thread(new ParameterizedThreadStart(<Module>.smethod_0));
			thread.IsBackground = true;
			thread.Start(Thread.CurrentThread);
			Thread.Sleep(500);
		}
		for (;;)
		{
			if (Debugger.IsAttached)
			{
				goto IL_41;
			}
			if (Debugger.IsLogging())
			{
				goto IL_41;
			}
			IL_47:
			if (!thread.IsAlive)
			{
				Environment.FailFast(null);
			}
			Thread.Sleep(1000);
			continue;
			IL_41:
			Environment.FailFast(null);
			goto IL_47;
		}
	}

	// Token: 0x06000003 RID: 3
	[DllImport("kernel32.dll")]
	internal unsafe static extern bool VirtualProtect(byte* pByte_0, int int_0, uint uint_0, ref uint uint_1);

	// Token: 0x06000004 RID: 4 RVA: 0x00003530 File Offset: 0x00001730
	internal static byte[] smethod_1(byte[] byte_1)
	{
		MemoryStream memoryStream = new MemoryStream(byte_1);
		<Module>.Class1 @class = new <Module>.Class1();
		byte[] buffer = new byte[5];
		memoryStream.Read(buffer, 0, 5);
		@class.method_5(buffer);
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
		}
		byte[] array = new byte[(int)num];
		MemoryStream stream_ = new MemoryStream(array, true);
		long long_ = memoryStream.Length - 13L;
		@class.method_4(memoryStream, stream_, long_, num);
		return array;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000035C4 File Offset: 0x000017C4
	internal static T smethod_2<T>(uint uint_0)
	{
		if (Assembly.GetExecutingAssembly().Equals(Assembly.GetExecutingAssembly()))
		{
			uint_0 = (uint_0 * 838599105U) ^ 886834318U;
			uint num = uint_0 >> 30;
			T result = default(T);
			uint_0 &= 1073741823U;
			uint_0 <<= 2;
			if ((ulong)num == 3UL)
			{
				int count = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
				result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
			}
			else if ((ulong)num != 1UL)
			{
				if ((ulong)num == 2UL)
				{
					int num2 = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
					int length = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
					Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
					Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, num2 - 4);
					result = (T)((object)array);
				}
			}
			else
			{
				T[] array2 = new T[1];
				Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, sizeof(T));
				result = array2[0];
			}
			return result;
		}
		return default(T);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00003778 File Offset: 0x00001978
	internal static T smethod_3<T>(uint uint_0)
	{
		if (Assembly.GetExecutingAssembly().Equals(Assembly.GetExecutingAssembly()))
		{
			uint_0 = (uint_0 * 3122675699U) ^ 3625443301U;
			uint num = uint_0 >> 30;
			T result = default(T);
			uint_0 &= 1073741823U;
			uint_0 <<= 2;
			if ((ulong)num != 3UL)
			{
				if ((ulong)num != 1UL)
				{
					if ((ulong)num == 2UL)
					{
						int num2 = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
						int length = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
						Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
						Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, num2 - 4);
						result = (T)((object)array);
					}
				}
				else
				{
					T[] array2 = new T[1];
					Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, sizeof(T));
					result = array2[0];
				}
			}
			else
			{
				int count = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
				result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
			}
			return result;
		}
		return default(T);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00003930 File Offset: 0x00001B30
	internal static T smethod_4<T>(uint uint_0)
	{
		if (Assembly.GetExecutingAssembly().Equals(Assembly.GetExecutingAssembly()))
		{
			uint_0 = (uint_0 * 313100133U) ^ 3779556620U;
			uint num = uint_0 >> 30;
			T result = default(T);
			uint_0 &= 1073741823U;
			uint_0 <<= 2;
			if ((ulong)num != 3UL)
			{
				if ((ulong)num != 2UL)
				{
					if ((ulong)num == 0UL)
					{
						int num2 = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
						int length = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
						Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
						Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, num2 - 4);
						result = (T)((object)array);
					}
				}
				else
				{
					T[] array2 = new T[1];
					Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, sizeof(T));
					result = array2[0];
				}
			}
			else
			{
				int count = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
				result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
			}
			return result;
		}
		return default(T);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00003AE8 File Offset: 0x00001CE8
	internal static T smethod_5<T>(uint uint_0)
	{
		if (Assembly.GetExecutingAssembly().Equals(Assembly.GetExecutingAssembly()))
		{
			uint_0 = (uint_0 * 3678271633U) ^ 465428271U;
			uint num = uint_0 >> 30;
			T result = default(T);
			uint_0 &= 1073741823U;
			uint_0 <<= 2;
			if ((ulong)num != 3UL)
			{
				if ((ulong)num == 2UL)
				{
					T[] array = new T[1];
					Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
					result = array[0];
				}
				else if ((ulong)num == 1UL)
				{
					int num2 = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
					int length = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
					Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
					Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
					result = (T)((object)array2);
				}
			}
			else
			{
				int count = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
				result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
			}
			return result;
		}
		return default(T);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00003C9C File Offset: 0x00001E9C
	internal static T smethod_6<T>(uint uint_0)
	{
		if (Assembly.GetExecutingAssembly().Equals(Assembly.GetExecutingAssembly()))
		{
			uint_0 = (uint_0 * 3751163487U) ^ 1690146369U;
			uint num = uint_0 >> 30;
			T result = default(T);
			uint_0 &= 1073741823U;
			uint_0 <<= 2;
			if ((ulong)num == 1UL)
			{
				int count = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
				result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
			}
			else if ((ulong)num == 3UL)
			{
				T[] array = new T[1];
				Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
				result = array[0];
			}
			else if ((ulong)num == 0UL)
			{
				int num2 = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
				int length = (int)<Module>.byte_0[(int)uint_0++] | ((int)<Module>.byte_0[(int)uint_0++] << 8) | ((int)<Module>.byte_0[(int)uint_0++] << 16) | ((int)<Module>.byte_0[(int)uint_0++] << 24);
				Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
				result = (T)((object)array2);
			}
			return result;
		}
		return default(T);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00003E50 File Offset: 0x00002050
	internal static void smethod_7()
	{
		uint num = 112U;
		uint[] array = new uint[]
		{
			4057339463U, 634624174U, 567588358U, 4059281583U, 1960244864U, 2899342415U, 2871710457U, 2760964018U, 1747148901U, 316132531U,
			3776513535U, 3979082877U, 1616177772U, 2779763017U, 2134385279U, 2448578211U, 3054754102U, 121131141U, 3683993667U, 2205999388U,
			458686340U, 1770920053U, 66508717U, 4170901141U, 3513970682U, 858237199U, 2586874337U, 3887970507U, 2188817705U, 2144096046U,
			2048549302U, 1948702618U, 1141718556U, 136887665U, 2239933763U, 3512065926U, 1868702166U, 2984762570U, 686809621U, 1464475169U,
			3164235703U, 1330692621U, 2265312538U, 1921773528U, 4184973539U, 1921445222U, 1990215196U, 1024791190U, 739561380U, 4286944090U,
			4062974492U, 832486202U, 1783496090U, 3603120075U, 2963624163U, 635247434U, 1231703323U, 3966000843U, 2246028620U, 2088726998U,
			895946158U, 2323330808U, 143014910U, 1664271045U, 1091428954U, 1213521382U, 918030189U, 2097722299U, 2581490138U, 242883650U,
			1881567328U, 4032705569U, 2509285767U, 3828141151U, 1760763287U, 4111934489U, 4051411189U, 643502938U, 3670229536U, 310059412U,
			1036798523U, 4284467036U, 1625410609U, 2108670389U, 189990559U, 1289022873U, 152585785U, 1468161796U, 3338471663U, 4112597961U,
			4171140888U, 1645002756U, 1228340209U, 3824561996U, 2195206014U, 3868053336U, 3394236863U, 1064360511U, 35709840U, 2045595963U,
			3173515589U, 3319508407U, 3286766252U, 1468723937U, 3338471663U, 4112597961U, 4171140888U, 1645002756U, 1228340209U, 3824561996U,
			2195206014U, 3868053336U
		};
		uint[] array2 = new uint[16];
		uint num2 = 1507121330U;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 13;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4U];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			array3[0] = array3[0] ^ array2[0];
			array3[1] = array3[1] ^ array2[1];
			array3[2] = array3[2] ^ array2[2];
			array3[3] = array3[3] ^ array2[3];
			array3[4] = array3[4] ^ array2[4];
			array3[5] = array3[5] ^ array2[5];
			array3[6] = array3[6] ^ array2[6];
			array3[7] = array3[7] ^ array2[7];
			array3[8] = array3[8] ^ array2[8];
			array3[9] = array3[9] ^ array2[9];
			array3[10] = array3[10] ^ array2[10];
			array3[11] = array3[11] ^ array2[11];
			array3[12] = array3[12] ^ array2[12];
			array3[13] = array3[13] ^ array2[13];
			array3[14] = array3[14] ^ array2[14];
			array3[15] = array3[15] ^ array2[15];
			for (int k = 0; k < 16; k++)
			{
				uint num5 = array3[k];
				array4[num4++] = (byte)num5;
				array4[num4++] = (byte)(num5 >> 8);
				array4[num4++] = (byte)(num5 >> 16);
				array4[num4++] = (byte)(num5 >> 24);
				array2[k] ^= num5;
			}
			num3 += 16;
		}
		<Module>.assembly_0 = Assembly.Load(<Module>.smethod_1(array4));
		AppDomain.CurrentDomain.AssemblyResolve += <Module>.smethod_8;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002850 File Offset: 0x00000A50
	internal static Assembly smethod_8(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (<Module>.assembly_0.FullName == resolveEventArgs_0.Name)
		{
			return <Module>.assembly_0;
		}
		return null;
	}

	// Token: 0x0600000C RID: 12
	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	internal static extern bool VirtualProtect_1(IntPtr intptr_0, uint uint_0, uint uint_1, ref uint uint_2);

	// Token: 0x0600000D RID: 13 RVA: 0x0000405C File Offset: 0x0000225C
	internal unsafe static void smethod_9()
	{
		Module module = typeof(<Module>).Module;
		string fullyQualifiedName = module.FullyQualifiedName;
		bool flag = fullyQualifiedName.Length > 0 && fullyQualifiedName[0] == '<';
		byte* ptr = (byte*)(void*)Marshal.GetHINSTANCE(module);
		byte* ptr2 = ptr + *(uint*)(ptr + 60);
		ushort num = *(ushort*)(ptr2 + 6);
		ushort num2 = *(ushort*)(ptr2 + 20);
		uint* ptr3 = null;
		uint num3 = 0U;
		uint* ptr4 = (uint*)(ptr2 + 24 + num2);
		uint num4 = 3552740841U;
		uint num5 = 4086514719U;
		uint num6 = 474889902U;
		uint num7 = 903560589U;
		for (int i = 0; i < (int)num; i++)
		{
			uint num8 = *(ptr4++) * *(ptr4++);
			if (num8 != 746333609U)
			{
				if (num8 != 0U)
				{
					uint* ptr5 = (uint*)(ptr + (UIntPtr)(flag ? ptr4[3] : ptr4[1]) / 4);
					uint num9 = ptr4[2] >> 2;
					for (uint num10 = 0U; num10 < num9; num10 += 1U)
					{
						uint num11 = (num4 ^ *(ptr5++)) + num5 + num6 * num7;
						num4 = num5;
						num5 = num7;
						num7 = num11;
					}
				}
			}
			else
			{
				ptr3 = (uint*)(ptr + (UIntPtr)(flag ? ptr4[3] : ptr4[1]) / 4);
				num3 = (flag ? ptr4[2] : (*ptr4)) >> 2;
			}
			ptr4 += 8;
		}
		uint[] array = new uint[16];
		uint[] array2 = new uint[16];
		for (int j = 0; j < 16; j++)
		{
			array[j] = num7;
			array2[j] = num5;
			num4 = (num5 >> 5) | (num5 << 27);
			num5 = (num6 >> 3) | (num6 << 29);
			num6 = (num7 >> 7) | (num7 << 25);
			num7 = (num4 >> 11) | (num4 << 21);
		}
		array[0] = array[0] ^ array2[0];
		array[1] = array[1] * array2[1];
		array[2] = array[2] + array2[2];
		array[3] = array[3] ^ array2[3];
		array[4] = array[4] * array2[4];
		array[5] = array[5] + array2[5];
		array[6] = array[6] ^ array2[6];
		array[7] = array[7] * array2[7];
		array[8] = array[8] + array2[8];
		array[9] = array[9] ^ array2[9];
		array[10] = array[10] * array2[10];
		array[11] = array[11] + array2[11];
		array[12] = array[12] ^ array2[12];
		array[13] = array[13] * array2[13];
		array[14] = array[14] + array2[14];
		array[15] = array[15] ^ array2[15];
		uint num12 = 64U;
		<Module>.VirtualProtect_1((IntPtr)((void*)ptr3), num3 << 2, 64U, ref num12);
		if (num12 != 64U)
		{
			uint num13 = 0U;
			for (uint num14 = 0U; num14 < num3; num14 += 1U)
			{
				*ptr3 ^= array[(int)(num13 & 15U)];
				array[(int)(num13 & 15U)] = (array[(int)(num13 & 15U)] ^ *(ptr3++)) + 1035675673U;
				num13 += 1U;
			}
			return;
		}
	}

	// Token: 0x04000001 RID: 1
	internal static byte[] byte_0;

	// Token: 0x04000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	internal static <Module>.Struct4 struct4_0;

	// Token: 0x04000003 RID: 3
	internal static Assembly assembly_0;

	// Token: 0x04000004 RID: 4 RVA: 0x00002690 File Offset: 0x00000890
	internal static <Module>.Struct5 struct5_0;

	// Token: 0x02000002 RID: 2
	internal struct Struct0
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002870 File Offset: 0x00000A70
		internal void method_0()
		{
			this.uint_0 = 1024U;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00004354 File Offset: 0x00002554
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = (class0_0.uint_1 >> 11) * this.uint_0;
			if (class0_0.uint_0 >= num)
			{
				class0_0.uint_1 -= num;
				class0_0.uint_0 -= num;
				this.uint_0 -= this.uint_0 >> 5;
				if (class0_0.uint_1 < 16777216U)
				{
					class0_0.uint_0 = (class0_0.uint_0 << 8) | (uint)((byte)class0_0.stream_0.ReadByte());
					class0_0.uint_1 <<= 8;
				}
				return 1U;
			}
			class0_0.uint_1 = num;
			this.uint_0 += 2048U - this.uint_0 >> 5;
			if (class0_0.uint_1 < 16777216U)
			{
				class0_0.uint_0 = (class0_0.uint_0 << 8) | (uint)((byte)class0_0.stream_0.ReadByte());
				class0_0.uint_1 <<= 8;
			}
			return 0U;
		}

		// Token: 0x04000005 RID: 5
		internal uint uint_0;
	}

	// Token: 0x02000003 RID: 3
	internal struct Struct1
	{
		// Token: 0x06000010 RID: 16 RVA: 0x0000287D File Offset: 0x00000A7D
		internal Struct1(int int_1)
		{
			this.int_0 = int_1;
			this.struct0_0 = new <Module>.Struct0[1 << int_1];
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00004440 File Offset: 0x00002640
		internal void method_0()
		{
			uint num = 1U;
			while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
			{
				this.struct0_0[(int)num].method_0();
				num += 1U;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00004478 File Offset: 0x00002678
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = 1U;
			for (int i = this.int_0; i > 0; i--)
			{
				num = (num << 1) + this.struct0_0[(int)num].method_1(class0_0);
			}
			return num - (1U << this.int_0);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000044BC File Offset: 0x000026BC
		internal uint method_2(<Module>.Class0 class0_0)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < this.int_0; i++)
			{
				uint num3 = this.struct0_0[(int)num].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00004504 File Offset: 0x00002704
		internal static uint smethod_0(<Module>.Struct0[] struct0_1, uint uint_0, <Module>.Class0 class0_0, int int_1)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < int_1; i++)
			{
				uint num3 = struct0_1[(int)(uint_0 + num)].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x04000006 RID: 6
		internal readonly <Module>.Struct0[] struct0_0;

		// Token: 0x04000007 RID: 7
		internal readonly int int_0;
	}

	// Token: 0x02000004 RID: 4
	internal class Class0
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00004544 File Offset: 0x00002744
		internal void method_0(Stream stream_1)
		{
			this.stream_0 = stream_1;
			this.uint_0 = 0U;
			this.uint_1 = uint.MaxValue;
			for (int i = 0; i < 5; i++)
			{
				this.uint_0 = (this.uint_0 << 8) | (uint)((byte)this.stream_0.ReadByte());
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002897 File Offset: 0x00000A97
		internal void method_1()
		{
			this.stream_0 = null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000028A0 File Offset: 0x00000AA0
		internal void method_2()
		{
			while (this.uint_1 < 16777216U)
			{
				this.uint_0 = (this.uint_0 << 8) | (uint)((byte)this.stream_0.ReadByte());
				this.uint_1 <<= 8;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004590 File Offset: 0x00002790
		internal uint method_3(int int_0)
		{
			uint num = this.uint_1;
			uint num2 = this.uint_0;
			uint num3 = 0U;
			for (int i = int_0; i > 0; i--)
			{
				num >>= 1;
				uint num4 = num2 - num >> 31;
				num2 -= num & (num4 - 1U);
				num3 = (num3 << 1) | (1U - num4);
				if (num < 16777216U)
				{
					num2 = (num2 << 8) | (uint)((byte)this.stream_0.ReadByte());
					num <<= 8;
				}
			}
			this.uint_1 = num;
			this.uint_0 = num2;
			return num3;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000028DB File Offset: 0x00000ADB
		internal Class0()
		{
		}

		// Token: 0x04000008 RID: 8
		internal uint uint_0;

		// Token: 0x04000009 RID: 9
		internal uint uint_1;

		// Token: 0x0400000A RID: 10
		internal Stream stream_0;
	}

	// Token: 0x02000005 RID: 5
	internal class Class1
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00004604 File Offset: 0x00002804
		internal Class1()
		{
			this.uint_0 = uint.MaxValue;
			int num = 0;
			while ((long)num < 4L)
			{
				this.struct1_0[num] = new <Module>.Struct1(6);
				num++;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000046F8 File Offset: 0x000028F8
		internal void method_0(uint uint_3)
		{
			if (this.uint_0 != uint_3)
			{
				this.uint_0 = uint_3;
				this.uint_1 = Math.Max(this.uint_0, 1U);
				uint uint_4 = Math.Max(this.uint_1, 4096U);
				this.class4_0.method_0(uint_4);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000028E3 File Offset: 0x00000AE3
		internal void method_1(int int_0, int int_1)
		{
			this.class3_0.method_0(int_0, int_1);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004744 File Offset: 0x00002944
		internal void method_2(int int_0)
		{
			uint num = 1U << int_0;
			this.class2_0.method_0(num);
			this.class2_1.method_0(num);
			this.uint_2 = num - 1U;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000477C File Offset: 0x0000297C
		internal void method_3(Stream stream_0, Stream stream_1)
		{
			this.class0_0.method_0(stream_0);
			this.class4_0.method_1(stream_1, this.bool_0);
			for (uint num = 0U; num < 12U; num += 1U)
			{
				for (uint num2 = 0U; num2 <= this.uint_2; num2 += 1U)
				{
					uint num3 = (num << 4) + num2;
					this.struct0_0[(int)num3].method_0();
					this.struct0_1[(int)num3].method_0();
				}
				this.struct0_2[(int)num].method_0();
				this.struct0_3[(int)num].method_0();
				this.struct0_4[(int)num].method_0();
				this.struct0_5[(int)num].method_0();
			}
			this.class3_0.method_1();
			for (uint num = 0U; num < 4U; num += 1U)
			{
				this.struct1_0[(int)num].method_0();
			}
			for (uint num = 0U; num < 114U; num += 1U)
			{
				this.struct0_6[(int)num].method_0();
			}
			this.class2_0.method_1();
			this.class2_1.method_1();
			this.struct1_1.method_0();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000048A0 File Offset: 0x00002AA0
		internal void method_4(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			this.method_3(stream_0, stream_1);
			<Module>.Struct3 @struct = default(<Module>.Struct3);
			@struct.method_0();
			uint num = 0U;
			uint num2 = 0U;
			uint num3 = 0U;
			uint num4 = 0U;
			ulong num5 = 0UL;
			if (0L < long_1)
			{
				this.struct0_0[(int)((int)@struct.uint_0 << 4)].method_1(this.class0_0);
				@struct.method_1();
				byte byte_ = this.class3_0.method_3(this.class0_0, 0U, 0);
				this.class4_0.method_5(byte_);
				num5 += 1UL;
			}
			while (num5 < (ulong)long_1)
			{
				uint num6 = (uint)num5 & this.uint_2;
				if (this.struct0_0[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class0_0) != 0U)
				{
					uint num8;
					if (this.struct0_2[(int)@struct.uint_0].method_1(this.class0_0) == 1U)
					{
						if (this.struct0_3[(int)@struct.uint_0].method_1(this.class0_0) != 0U)
						{
							uint num7;
							if (this.struct0_4[(int)@struct.uint_0].method_1(this.class0_0) == 0U)
							{
								num7 = num2;
							}
							else
							{
								if (this.struct0_5[(int)@struct.uint_0].method_1(this.class0_0) == 0U)
								{
									num7 = num3;
								}
								else
								{
									num7 = num4;
									num4 = num3;
								}
								num3 = num2;
							}
							num2 = num;
							num = num7;
						}
						else if (this.struct0_1[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class0_0) == 0U)
						{
							@struct.method_4();
							this.class4_0.method_5(this.class4_0.method_6(num));
							num5 += 1UL;
							continue;
						}
						num8 = this.class2_1.method_2(this.class0_0, num6) + 2U;
						@struct.method_3();
					}
					else
					{
						num4 = num3;
						num3 = num2;
						num2 = num;
						num8 = 2U + this.class2_0.method_2(this.class0_0, num6);
						@struct.method_2();
						uint num9 = this.struct1_0[(int)<Module>.Class1.smethod_0(num8)].method_1(this.class0_0);
						if (num9 >= 4U)
						{
							int num10 = (int)((num9 >> 1) - 1U);
							num = (2U | (num9 & 1U)) << num10;
							if (num9 < 14U)
							{
								num += <Module>.Struct1.smethod_0(this.struct0_6, num - num9 - 1U, this.class0_0, num10);
							}
							else
							{
								num += this.class0_0.method_3(num10 - 4) << 4;
								num += this.struct1_1.method_2(this.class0_0);
							}
						}
						else
						{
							num = num9;
						}
					}
					if (((ulong)num >= num5 || num >= this.uint_1) && num == 4294967295U)
					{
						break;
					}
					this.class4_0.method_4(num, num8);
					num5 += (ulong)num8;
				}
				else
				{
					byte byte_2 = this.class4_0.method_6(0U);
					byte byte_3;
					if (!@struct.method_5())
					{
						byte_3 = this.class3_0.method_4(this.class0_0, (uint)num5, byte_2, this.class4_0.method_6(num));
					}
					else
					{
						byte_3 = this.class3_0.method_3(this.class0_0, (uint)num5, byte_2);
					}
					this.class4_0.method_5(byte_3);
					@struct.method_1();
					num5 += 1UL;
				}
			}
			this.class4_0.method_3();
			this.class4_0.method_2();
			this.class0_0.method_1();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004C08 File Offset: 0x00002E08
		internal void method_5(byte[] byte_0)
		{
			int int_ = (int)(byte_0[0] % 9);
			byte b = byte_0[0] / 9;
			int int_2 = (int)(b % 5);
			int int_3 = (int)(b / 5);
			uint num = 0U;
			for (int i = 0; i < 4; i++)
			{
				num += (uint)((uint)byte_0[1 + i] << i * 8);
			}
			this.method_0(num);
			this.method_1(int_2, int_);
			this.method_2(int_3);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000028F2 File Offset: 0x00000AF2
		internal static uint smethod_0(uint uint_3)
		{
			uint_3 -= 2U;
			if (uint_3 < 4U)
			{
				return uint_3;
			}
			return 3U;
		}

		// Token: 0x0400000B RID: 11
		internal readonly <Module>.Struct0[] struct0_0 = new <Module>.Struct0[192];

		// Token: 0x0400000C RID: 12
		internal readonly <Module>.Struct0[] struct0_1 = new <Module>.Struct0[192];

		// Token: 0x0400000D RID: 13
		internal readonly <Module>.Struct0[] struct0_2 = new <Module>.Struct0[12];

		// Token: 0x0400000E RID: 14
		internal readonly <Module>.Struct0[] struct0_3 = new <Module>.Struct0[12];

		// Token: 0x0400000F RID: 15
		internal readonly <Module>.Struct0[] struct0_4 = new <Module>.Struct0[12];

		// Token: 0x04000010 RID: 16
		internal readonly <Module>.Struct0[] struct0_5 = new <Module>.Struct0[12];

		// Token: 0x04000011 RID: 17
		internal readonly <Module>.Class1.Class2 class2_0 = new <Module>.Class1.Class2();

		// Token: 0x04000012 RID: 18
		internal readonly <Module>.Class1.Class3 class3_0 = new <Module>.Class1.Class3();

		// Token: 0x04000013 RID: 19
		internal readonly <Module>.Class4 class4_0 = new <Module>.Class4();

		// Token: 0x04000014 RID: 20
		internal readonly <Module>.Struct0[] struct0_6 = new <Module>.Struct0[114];

		// Token: 0x04000015 RID: 21
		internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[4];

		// Token: 0x04000016 RID: 22
		internal readonly <Module>.Class0 class0_0 = new <Module>.Class0();

		// Token: 0x04000017 RID: 23
		internal readonly <Module>.Class1.Class2 class2_1 = new <Module>.Class1.Class2();

		// Token: 0x04000018 RID: 24
		internal bool bool_0;

		// Token: 0x04000019 RID: 25
		internal uint uint_0;

		// Token: 0x0400001A RID: 26
		internal uint uint_1;

		// Token: 0x0400001B RID: 27
		internal <Module>.Struct1 struct1_1 = new <Module>.Struct1(4);

		// Token: 0x0400001C RID: 28
		internal uint uint_2;

		// Token: 0x02000006 RID: 6
		internal class Class2
		{
			// Token: 0x06000022 RID: 34 RVA: 0x00004C64 File Offset: 0x00002E64
			internal void method_0(uint uint_1)
			{
				for (uint num = this.uint_0; num < uint_1; num += 1U)
				{
					this.struct1_0[(int)num] = new <Module>.Struct1(3);
					this.struct1_1[(int)num] = new <Module>.Struct1(3);
				}
				this.uint_0 = uint_1;
			}

			// Token: 0x06000023 RID: 35 RVA: 0x00004CB0 File Offset: 0x00002EB0
			internal void method_1()
			{
				this.struct0_0.method_0();
				for (uint num = 0U; num < this.uint_0; num += 1U)
				{
					this.struct1_0[(int)num].method_0();
					this.struct1_1[(int)num].method_0();
				}
				this.struct0_1.method_0();
				this.struct1_2.method_0();
			}

			// Token: 0x06000024 RID: 36 RVA: 0x00004D14 File Offset: 0x00002F14
			internal uint method_2(<Module>.Class0 class0_0, uint uint_1)
			{
				if (this.struct0_0.method_1(class0_0) == 0U)
				{
					return this.struct1_0[(int)uint_1].method_1(class0_0);
				}
				uint num = 8U;
				if (this.struct0_1.method_1(class0_0) == 0U)
				{
					num += this.struct1_1[(int)uint_1].method_1(class0_0);
				}
				else
				{
					num += 8U;
					num += this.struct1_2.method_1(class0_0);
				}
				return num;
			}

			// Token: 0x06000025 RID: 37 RVA: 0x00002900 File Offset: 0x00000B00
			internal Class2()
			{
			}

			// Token: 0x0400001D RID: 29
			internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[16];

			// Token: 0x0400001E RID: 30
			internal readonly <Module>.Struct1[] struct1_1 = new <Module>.Struct1[16];

			// Token: 0x0400001F RID: 31
			internal <Module>.Struct0 struct0_0;

			// Token: 0x04000020 RID: 32
			internal <Module>.Struct0 struct0_1;

			// Token: 0x04000021 RID: 33
			internal <Module>.Struct1 struct1_2 = new <Module>.Struct1(8);

			// Token: 0x04000022 RID: 34
			internal uint uint_0;
		}

		// Token: 0x02000007 RID: 7
		internal class Class3
		{
			// Token: 0x06000026 RID: 38 RVA: 0x00004D80 File Offset: 0x00002F80
			internal void method_0(int int_2, int int_3)
			{
				if (this.struct2_0 != null)
				{
					if (this.int_1 == int_3)
					{
						if (this.int_0 == int_2)
						{
							return;
						}
					}
				}
				this.int_0 = int_2;
				this.uint_0 = (1U << int_2) - 1U;
				this.int_1 = int_3;
				uint num = 1U << this.int_1 + this.int_0;
				this.struct2_0 = new <Module>.Class1.Class3.Struct2[num];
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.struct2_0[(int)num2].method_0();
				}
			}

			// Token: 0x06000027 RID: 39 RVA: 0x00004E04 File Offset: 0x00003004
			internal void method_1()
			{
				uint num = 1U << this.int_1 + this.int_0;
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.struct2_0[(int)num2].method_1();
				}
			}

			// Token: 0x06000028 RID: 40 RVA: 0x0000292E File Offset: 0x00000B2E
			internal uint method_2(uint uint_1, byte byte_0)
			{
				return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
			}

			// Token: 0x06000029 RID: 41 RVA: 0x00002950 File Offset: 0x00000B50
			internal byte method_3(<Module>.Class0 class0_0, uint uint_1, byte byte_0)
			{
				return this.struct2_0[(int)this.method_2(uint_1, byte_0)].method_2(class0_0);
			}

			// Token: 0x0600002A RID: 42 RVA: 0x0000296B File Offset: 0x00000B6B
			internal byte method_4(<Module>.Class0 class0_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return this.struct2_0[(int)this.method_2(uint_1, byte_0)].method_3(class0_0, byte_1);
			}

			// Token: 0x0600002B RID: 43 RVA: 0x000028DB File Offset: 0x00000ADB
			internal Class3()
			{
			}

			// Token: 0x04000023 RID: 35
			internal <Module>.Class1.Class3.Struct2[] struct2_0;

			// Token: 0x04000024 RID: 36
			internal int int_0;

			// Token: 0x04000025 RID: 37
			internal int int_1;

			// Token: 0x04000026 RID: 38
			internal uint uint_0;

			// Token: 0x02000008 RID: 8
			internal struct Struct2
			{
				// Token: 0x0600002C RID: 44 RVA: 0x00002988 File Offset: 0x00000B88
				internal void method_0()
				{
					this.struct0_0 = new <Module>.Struct0[768];
				}

				// Token: 0x0600002D RID: 45 RVA: 0x00004E44 File Offset: 0x00003044
				internal void method_1()
				{
					for (int i = 0; i < 768; i++)
					{
						this.struct0_0[i].method_0();
					}
				}

				// Token: 0x0600002E RID: 46 RVA: 0x00004E74 File Offset: 0x00003074
				internal byte method_2(<Module>.Class0 class0_0)
				{
					uint num = 1U;
					do
					{
						num = (num << 1) | this.struct0_0[(int)num].method_1(class0_0);
					}
					while (num < 256U);
					return (byte)num;
				}

				// Token: 0x0600002F RID: 47 RVA: 0x00004EA8 File Offset: 0x000030A8
				internal byte method_3(<Module>.Class0 class0_0, byte byte_0)
				{
					uint num = 1U;
					for (;;)
					{
						uint num2 = (uint)((byte_0 >> 7) & 1);
						byte_0 = (byte)(byte_0 << 1);
						uint num3 = this.struct0_0[(int)((1U + num2 << 8) + num)].method_1(class0_0);
						num = (num << 1) | num3;
						if (num2 != num3)
						{
							break;
						}
						if (num >= 256U)
						{
							goto IL_5C;
						}
					}
					while (num < 256U)
					{
						num = (num << 1) | this.struct0_0[(int)num].method_1(class0_0);
					}
					IL_5C:
					return (byte)num;
				}

				// Token: 0x04000027 RID: 39
				internal <Module>.Struct0[] struct0_0;
			}
		}
	}

	// Token: 0x02000009 RID: 9
	internal class Class4
	{
		// Token: 0x06000030 RID: 48 RVA: 0x0000299A File Offset: 0x00000B9A
		internal void method_0(uint uint_3)
		{
			if (this.uint_2 != uint_3)
			{
				this.byte_0 = new byte[uint_3];
			}
			this.uint_2 = uint_3;
			this.uint_0 = 0U;
			this.uint_1 = 0U;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000029C6 File Offset: 0x00000BC6
		internal void method_1(Stream stream_1, bool bool_0)
		{
			this.method_2();
			this.stream_0 = stream_1;
			if (!bool_0)
			{
				this.uint_1 = 0U;
				this.uint_0 = 0U;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000029E6 File Offset: 0x00000BE6
		internal void method_2()
		{
			this.method_3();
			this.stream_0 = null;
			Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004F14 File Offset: 0x00003114
		internal void method_3()
		{
			uint num = this.uint_0 - this.uint_1;
			if (num == 0U)
			{
				return;
			}
			this.stream_0.Write(this.byte_0, (int)this.uint_1, (int)num);
			if (this.uint_0 >= this.uint_2)
			{
				this.uint_0 = 0U;
			}
			this.uint_1 = this.uint_0;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004F6C File Offset: 0x0000316C
		internal void method_4(uint uint_3, uint uint_4)
		{
			uint num = this.uint_0 - uint_3 - 1U;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			while (uint_4 > 0U)
			{
				if (num >= this.uint_2)
				{
					num = 0U;
				}
				byte[] array = this.byte_0;
				uint num2 = this.uint_0;
				this.uint_0 = num2 + 1U;
				array[(int)num2] = this.byte_0[(int)num++];
				if (this.uint_0 >= this.uint_2)
				{
					this.method_3();
				}
				uint_4 -= 1U;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004FE4 File Offset: 0x000031E4
		internal void method_5(byte byte_1)
		{
			byte[] array = this.byte_0;
			uint num = this.uint_0;
			this.uint_0 = num + 1U;
			array[(int)num] = byte_1;
			if (this.uint_0 >= this.uint_2)
			{
				this.method_3();
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005020 File Offset: 0x00003220
		internal byte method_6(uint uint_3)
		{
			uint num = this.uint_0 - uint_3 - 1U;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			return this.byte_0[(int)num];
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000028DB File Offset: 0x00000ADB
		internal Class4()
		{
		}

		// Token: 0x04000028 RID: 40
		internal byte[] byte_0;

		// Token: 0x04000029 RID: 41
		internal uint uint_0;

		// Token: 0x0400002A RID: 42
		internal Stream stream_0;

		// Token: 0x0400002B RID: 43
		internal uint uint_1;

		// Token: 0x0400002C RID: 44
		internal uint uint_2;
	}

	// Token: 0x0200000A RID: 10
	internal struct Struct3
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00002A17 File Offset: 0x00000C17
		internal void method_0()
		{
			this.uint_0 = 0U;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002A20 File Offset: 0x00000C20
		internal void method_1()
		{
			if (this.uint_0 < 4U)
			{
				this.uint_0 = 0U;
				return;
			}
			if (this.uint_0 >= 10U)
			{
				this.uint_0 -= 6U;
				return;
			}
			this.uint_0 -= 3U;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002A5A File Offset: 0x00000C5A
		internal void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002A70 File Offset: 0x00000C70
		internal void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002A86 File Offset: 0x00000C86
		internal void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002A9D File Offset: 0x00000C9D
		internal bool method_5()
		{
			return this.uint_0 < 7U;
		}

		// Token: 0x0400002D RID: 45
		internal uint uint_0;
	}

	// Token: 0x0200000B RID: 11
	[StructLayout(LayoutKind.Explicit, Size = 1600)]
	internal struct Struct4
	{
	}

	// Token: 0x0200000C RID: 12
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 448)]
	internal struct Struct5
	{
	}
}
