Feature: Auth


@mytag
Scenario: Auth on site
	Given Open site http://u920152e.beget.tech/#
	And Enter email "Andrey@student.com"
	When Enter password "password"
	Then Click button Enter