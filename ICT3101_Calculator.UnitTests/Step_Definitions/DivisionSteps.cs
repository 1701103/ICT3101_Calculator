using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    public class ContextInjection
    {
        public double result;

        public ContextInjection()
        {
            Calculator = new Calculator();
        }

        public Calculator Calculator { get; private set; }
    }

    [Binding]
    public class DivisionSteps
    {
        private readonly ContextInjection _contextInjection;

        public DivisionSteps(ContextInjection contextInjection)
        {
            _contextInjection = contextInjection;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0, double p1)
        {
            _contextInjection.result = _contextInjection.Calculator.Divide(p0, p1);
        }
        
        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(_contextInjection.result, Is.EqualTo(p0));
        }

        [Then(@"the division result should be Infinity on the screen")]
        public void ThenTheDivisionResultShouldBeOnTheSCreen()
        {
            Assert.That(_contextInjection.result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}
