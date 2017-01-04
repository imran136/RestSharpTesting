Feature: ApiTest
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: As an authenticated user, I want to add data
	Given user has following credentials
	| username   | password  |
	| shantonu   | 123456    |  	
	When user makes an add query
	Then user should be able to add data
