Feature:Credentials2
	Login Into Trisus


Scenario: Login with Credentials2
	Given I navigate to Tris
	When I enter my correct cred
	Then I am logged in