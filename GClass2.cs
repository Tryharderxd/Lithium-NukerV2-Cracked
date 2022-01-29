using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class GClass2
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class13<T>
	{
		public static readonly Class13<T> _003C_003E9 = new Class13<T>();

		public static Func<List<T>, bool> _003C_003E9__0_0;

		internal bool method_0(List<T> list_0)
		{
			return list_0.Count > 0;
		}
	}

	public static List<List<T>> smethod_0<T>(List<T> list_0, int int_0)
	{
		List<List<T>> list = new List<List<T>>();
		for (int i = 0; i < int_0; i++)
		{
			list.Add(new List<T>());
		}
		for (int j = 0; j < list_0.Count; j++)
		{
			list[j % int_0].Add(list_0[j]);
		}
		return list.Where((List<T> list_0) => list_0.Count > 0).ToList();
	}
}
