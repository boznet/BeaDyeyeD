using NSubstitute;
using NUnit.Framework;

namespace boznet.Beady_Eyed.Test
{
	[TestFixture]
	public class CalculatorTests : Bdd<CalculatorTests>
	{
		private ICalculator _calculator;
		private int _actual;

		/// <summary>
		/// Test showing how to follow AAA pattern using the BDD approach
		/// What I like is the test makes sense now and it will still make sense 
		/// in 5 years when someone add a breaking change
		/// </summary>
		[Test]
		public void Add_Return_Correct_Value()
		{
			Given.
				A_Calculator();
			When.
				Add_Is_Called();
			Then.
				Correct_Value_Is_Returned();
		}
		
		/// <summary>
		/// Same test but using a mocked calculator
		/// This shows the use of And to make the test upport more complicated User Stories
		/// </summary>
		[Test]
		public void Add_Calls_Correct_Methods()
		{
			Given.
				A_Mock_Calculator();
			When.
				Add_Is_Called();
			Then.
				Add_Was_Called();
			And.
				Subtract_Was_Not_Called();
		}

		private void Subtract_Was_Not_Called()
		{
			_calculator.DidNotReceive().Subtract(Arg.Any<int>(), Arg.Any<int>());
		}

		private void Add_Was_Called()
		{
			_calculator.Received().Add(5, 9);
		}

		private void Add_Is_Called()
		{
			_actual = _calculator.Add(5, 9);
		}

		private void A_Mock_Calculator()
		{
			_calculator = Substitute.For<ICalculator>();
		}

		private void Correct_Value_Is_Returned()
		{
			Assert.AreEqual(14, _actual);
		}

		private void A_Calculator()
		{
			_calculator = new Calculator();
		}
	}
}
