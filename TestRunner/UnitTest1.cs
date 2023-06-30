using Programmers_LV0;
namespace TestRunner;

public class Tests {
	CalculateStrings _calculateStrings;
	OXQuiz _oXQuiz;

	[SetUp]
	public void Setup() {
		_calculateStrings = new CalculateStrings();
		_oXQuiz = new OXQuiz();
	}

	[Test]
	public void OK_CalculateStrings() {
		int res1 = _calculateStrings.Solution("3 + 4");
		int exp1 = 7;
		Assert.AreEqual(exp1, res1);

		int res2 = _calculateStrings.Solution("3 + 4 - 1");
		int exp2 = 6;
		Assert.AreEqual(exp2, res2);

		int res3 = _calculateStrings.Solution("3 + 4 + 1");
		int exp3 = 8;
		Assert.AreEqual(exp3, res3);

		int res4 = _calculateStrings.Solution("-3 + 4");
		int exp4 = 1;
		Assert.AreEqual(exp4, res4);
	}

	[Test]
	public void OK_OXQuiz() {
		string[] res1 = _oXQuiz.Solution(new[] { "3 - 4 = -3", "5 + 6 = 11" });
		string[] exp1 = new[] { "X", "O" };
		for (int i = 0; i < res1.Length; i++) {
			Assert.AreEqual(exp1[i], res1[i]);
		}

		string[] res2 = _oXQuiz.Solution(new[] { "19 - 6 = 13", "5 + 66 = 71", "5 - 15 = 63", "3 - 1 = 2" });
		string[] exp2 = new[] { "O", "O", "X", "O" };
		for (int i = 0; i < res2.Length; i++) {
			Assert.AreEqual(exp2[i], res2[i]);
		}
	}
}
