using ICT3101_Calculator.UnitTests.Step_Definitions;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
    [Binding]
    public class FactorialSteps
    {
        private readonly ContextInjection _contextInjection;

        public FactorialSteps(ContextInjection contextInjection)
        {
            _contextInjection = contextInjection;
        }

        [Given(@"I have entered ""(.*)"" into the calculator and press factorial")]
        public void GivenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
        {
            _contextInjection.result = _contextInjection.Calculator.Factorial(p0);
        }

        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(_contextInjection.result, Is.EqualTo(p0));
        }
    }
}
