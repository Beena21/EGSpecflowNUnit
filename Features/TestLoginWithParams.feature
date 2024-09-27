Feature: TestLoginWithParams

Test Login with test data parameters - (feature file with parameters)

Background: 
		Given User is on login page

@Sanity
Scenario: Verify Login functionality
	Given User is on login page
	When User enters the username and password
	And User Clicks on login button
	Then User is navigated to home page

@Regression
Scenario Outline: Verify Login with test parameters
	Given User is on login page
	When User enters the "<username>" and "<password>"
	And User Clicks on login button
	Then User is navigated to home page
	Then User selected city and country information
	| city	 | country |
	| Delhi	 | India   |
	| Boston | USA	   | 

Examples: 
| username | password |
| tom      | Harry    |
| jerry    | Mathew   |


