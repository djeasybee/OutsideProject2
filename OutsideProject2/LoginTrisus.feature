Feature: LoginTrisus
	Login Into Trisus


Scenario: Login with Credentials1
	Given I navigate to Trisus
	When I correct credentials
	Then I am logged into Trisus

	Scenario: Login with Credentials1b
	Given I navigate to Trisus
	When I correct credentials
	Then I am logged into Trisus

