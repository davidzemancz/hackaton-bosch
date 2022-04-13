using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bosch.Shared
{
	public class Helpers
	{
		public static string ListToString<T>(IList<T> list)
		{
			string ret = "";
			if (list != null)
			{
				foreach(T item in list)
				{
					if (item == null) continue;
					ret += item.ToString() + ";";
				}
			}
			return ret;
		}
	}
}
