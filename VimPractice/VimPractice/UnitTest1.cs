using NUnit.Framework;

namespace VimPractice
{
	public class Tests
	{
		[SetUp]
		public void SetUp()
		{
			_tennis = new Tennis("Player1", "Player2");
		}
		private Tennis _tennis;

		[Test]
		public void Love_All()
		{
			ScoreShouldBe(_tennis, "Love All");
		}

		[Test]
		public void Fifteen_Love()
		{
			GivenFirstPlayerScore(1);
			ScoreShouldBe(_tennis, "Fifteen Love");
		}

		[Test]
		public void Thirty_Love()
		{
			GivenFirstPlayerScore(2);
			ScoreShouldBe(_tennis, "Thirty Love");
		}

		[Test]
		public void Forty_Love()
		{
			GivenFirstPlayerScore(3);
			ScoreShouldBe(_tennis, "Forty Love");
		}

		[Test]
		public void Love_Fifteen()
		{
			GivenSecondPlayerScore(1);
			ScoreShouldBe(_tennis, "Love Fifteen");
		}

		[Test]
		public void Love_Thirty()
		{
			GivenSecondPlayerScore(2);
			ScoreShouldBe(_tennis, "Love Thirty");
		}

		[Test]
		public void Love_Forty()
		{
			GivenSecondPlayerScore(3);
			ScoreShouldBe(_tennis, "Love Forty");
		}

		[Test]
		public void Fifteen_All()
		{
			GivenFirstPlayerScore(1);
			GivenSecondPlayerScore(1);
			ScoreShouldBe(_tennis, "Fifteen All");
		}

		[Test]
		public void Thirty_All()
		{
			GivenFirstPlayerScore(2);
			GivenSecondPlayerScore(2);
			ScoreShouldBe(_tennis, "Thirty All");
		}

		[Test]
		public void Deuce()
		{
			GivenDeuce();
			ScoreShouldBe(_tennis, "Deuce");
		}

		[Test]
		public void FirstPlayer_Adv()
		{
			GivenDeuce();
			GivenFirstPlayerScore(1);
			ScoreShouldBe(_tennis, "Player1 Adv");
		}

		[Test]
		public void SecondPlayer_Adv()
		{
			GivenDeuce();
			GivenSecondPlayerScore(1);
			ScoreShouldBe(_tennis, "Player2 Adv");
		}

		[Test]
		public void SecondPlayer_Win()
		{
			GivenDeuce();
			GivenSecondPlayerScore(2);
			ScoreShouldBe(_tennis, "Player2 Win");
		}

		[Test]
		public void FirstPlayer_Win()
		{
			GivenDeuce();
			GivenFirstPlayerScore(2);
			ScoreShouldBe(_tennis, "Player1 Win");
		}

		private void GivenDeuce()
		{
			GivenFirstPlayerScore(3);
			GivenSecondPlayerScore(3);
		}

		private void GivenSecondPlayerScore(int times)
		{
			for (int i = 0; i < times; i++)
			{
				_tennis.SecondPlayerScore();
			}
		}

		private void GivenFirstPlayerScore(int times)
		{
			for (int i = 0; i < times; i++)
			{
				_tennis.FirstPlayerScore();
			}
		}

		private static void ScoreShouldBe(Tennis tennis, string expected)
		{
			Assert.AreEqual(expected, tennis.Score());
		}
	}
}