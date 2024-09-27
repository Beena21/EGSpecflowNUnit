Feature: Test Login Functionality

Feature to test the login functionalities

@Regression,Sanity
Scenario: Verify Login functionality
	Given User is on login page
	When User enters the username and password
	And User Clicks on login button
	Then User is navigated to home page
