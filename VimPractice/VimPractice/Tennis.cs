using System.Collections.Generic;

namespace VimPractice
{
	public class Tennis
	{
		private int _firstPlayerScore;
		private int _secondPlayerScore;

		public string Score()
		{
			var scoreLookup = new Dictionary<int, string>()
			{
				{0, "Love" },
				{1, "Fifteen" },
				{2, "Thirty" },
				{3, "Forty" },
			};
			if (_firstPlayerScore > 0 || _secondPlayerScore > 0)
			{
				return $"{scoreLookup[_firstPlayerScore]} {scoreLookup[_secondPlayerScore]}";
			}
			return "Love All";
		}

		public void FirstPlayerScore()
		{
			_firstPlayerScore++;
		}

		public void SecondPlayerScore()
		{
			_secondPlayerScore++;
		}
	}
}