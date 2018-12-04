Feature: LoginAndOutWithCredential4
	Login and Logout

@mytag
Scenario: Login with Credentials4
	Given I navigate to the Trisus
	When I enter correct credentials
	And Log Out
	Then I am returned to the Login Page
