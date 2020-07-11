using System.Collections.Generic;

namespace VimPractice
{
	public class Tennis
	{
		private int _firstPlayerScore;
		private int _secondPlayerScore;

		private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
		{
			{0, "Love" },
			{1, "Fifteen" },
			{2, "Thirty" },
			{3, "Forty" },
		};

		public string Score()
		{
			if (_firstPlayerScore != _secondPlayerScore)
			{
				return LookupScore();
			}

			if (IsDeuce())
			{
				return Deuce();
			}
			
			return ScoreAll();
		}

		private string ScoreAll()
		{
			return $"{_scoreLookup[_firstPlayerScore]} All";
		}

		private string LookupScore()
		{
			return $"{_scoreLookup[_firstPlayerScore]} {_scoreLookup[_secondPlayerScore]}";
		}

		private static string Deuce()
		{
			return "Deuce";
		}

		private bool IsDeuce()
		{
			return _firstPlayerScore >= 3 && _firstPlayerScore == _secondPlayerScore;
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