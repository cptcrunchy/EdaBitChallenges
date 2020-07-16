using System.Linq;

namespace EdaBitChallenges
{
	public static class StringChallenges
	{
		public static string ReverseCase(string str)
		{
			return string.Concat(str
				.ToCharArray()
				.Select(c => char.IsLower(c) ? c.ToString().ToUpper() : c.ToString().ToLower())
				.ToArray());
		}
	}
}
