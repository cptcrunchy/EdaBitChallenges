using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EdaBitChallenges
{
	public class RollingCipher
	{
		public string Cipher(string str, int n)
		{
			return string.Join("", str.ToCharArray().Select(c => {
				var d = c < 'a' ? 65 : 97;
				var diff = n < 0 ? (26 + n) : n;
				return char.ConvertFromUtf32((c - d + diff) % 26 + d);				
			}).ToArray());
		}
	}
}
