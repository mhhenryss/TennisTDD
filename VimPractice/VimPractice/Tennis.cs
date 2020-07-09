using System.Collections.Generic;

namespace VimPractice
{
	public class Tennis
	{
		private int _fistPlayerScoreTimes;
		private int _secondPlayerScoreTimes;

		public string Score()
		{
			var scoreLookup = new Dictionary<int, string>()
			{
				{0, "Love" },
				{1, "Fifteen" },
				{2, "Thirty" },
				{3, "Forty" },
			};
			if (_fistPlayerScoreTimes > 0 || _secondPlayerScoreTimes > 0)
			{
				return $"{scoreLookup[_fistPlayerScoreTimes]} {scoreLookup[_secondPlayerScoreTimes]}";
			}
			return "Love All";
		}

		public void FirstPlayerScore()
		{
			_fistPlayerScoreTimes++;
		}

		public void SecondPlayerScore()
		{
			_secondPlayerScoreTimes++;
		}
	}
}