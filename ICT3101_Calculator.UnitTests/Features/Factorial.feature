Feature: Factorial
	In order to conquer factorial
	As a factorial enthusiast
	I want to calculate factorial as fast as possible

@Factorial
Scenario: Factorial
	Given I have a calculator
	And I have entered "3" into the calculator and press factorial
	Then the factorial result should be "6"
