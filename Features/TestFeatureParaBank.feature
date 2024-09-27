Feature: TestFeatureParaBank

Verify Login functionality

@tag1
Scenario Outline: Verify Registration functionality
	Given User is on the Login Page
	When User Clicks on Register Link 
	When User enters "<firstname>" and "<lastname>" and "<address>" and "<city>" and "<state>" and "<zipcode>" and "<phone>" and "<SSN>" and "<username>" and "<password>" and "<confirmpassword>"
	And clicks on Register button
	Then User is navigated to a page which displays Account created succesful

Examples: 
| firstname | lastname | address | city      | state     | zipcode | phone      | SSN   | username | password | confirmpassword |
| Bina      | Lavita   | Bejai   | Mangalore | Karnataka | 575001  | 1234567899 | 12345 | Bina1234 | b123     | b123             |
| Gauthami  | Jagadish | Bejai   | Mangalore | Karnataka | 575002  | 9876543210 | 54321 | Gau1234  | g12      | g12              |

Scenario Outline: Verify invalid credentaials
	Given User is on the Login Page
	When User Clicks on Register Link 
	Then Registration form page will open
	When User enters "<username>" and "<password>" 
	And clicks on Register button
	Then User displayed with an error message saying Invalid
Examples:
| username | password |
| Bina     | bina     |