using NUnit.Framework;

namespace VimPractice
{
	public class Tests
	{
		private Tennis _tennis;

		[SetUp]
		public void SetUp()
		{
			_tennis = new Tennis();
		}

		[Test]
		public void Love_All()
		{
			ScoreShouldBe("Love All");
		}

		[Test]
		public void Fifteen_Love()
		{
			_tennis.FirstPlayerScore();
			ScoreShouldBe("Fifteen Love");
		}

		[Test]
		public void Thirty_Love()
		{
			GivenFirstPlayerScore(2);
			ScoreShouldBe("Thirty Love");
		}

		[Test]
		public void Forty_Love()
		{
			GivenFirstPlayerScore(3);
			ScoreShouldBe("Forty Love");
		}

		[Test]
		public void Love_Fifteen()
		{
			GivenSecondPlayerScore(1);
			ScoreShouldBe("Love Fifteen");
		}

		[Test]
		public void Love_Thirty()
		{
			GivenSecondPlayerScore(2);
			ScoreShouldBe("Love Thirty");
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
			for (var i = 0; i < times; i++)
			{
				_tennis.FirstPlayerScore();
			}
		}

		private void ScoreShouldBe(string expected)
		{
			Assert.AreEqual(expected, _tennis.Score());
		}
	}
}