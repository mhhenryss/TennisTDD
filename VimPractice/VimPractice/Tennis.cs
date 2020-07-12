using System;
using System.Collections.Generic;

namespace VimPractice
{
	public class Tennis
	{
		private string _firstPlayerName;
		private int _firstPlayerScore;

		private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
		{
			{0, "Love"},
			{1, "Fifteen"},
			{2, "Thirty"},
			{3, "Forty"},
		};

		private string _secondPlayerName;
		private int _secondPlayerScore;

		public Tennis(string firstPlayerName, string secondPlayerName)
		{
			_firstPlayerName = firstPlayerName;
			_secondPlayerName = secondPlayerName;
		}

		public string Score()
		{
			return AreScoreSame()
				? IsDeuce()
					? Deuce()
					: ScoreAll()
				: IsReadyForGamePoint()
					? AdvState()
					: LookupScore();
		}

		private bool AreScoreSame()
		{
			return _firstPlayerScore == _secondPlayerScore;
		}

		private bool IsReadyForGamePoint()
		{
			return _firstPlayerScore > 3 || _secondPlayerScore > 3;
		}

		private string AdvState()
		{
			if (IsAdv())
			{
				return $"{AdvPlayer()} Adv";
			}

			return $"{AdvPlayer()} Win";
		}

		private string AdvPlayer()
		{
			return _firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName;
		}

		private bool IsAdv()
		{
			return Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1;
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