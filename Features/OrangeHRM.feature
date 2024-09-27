Feature: OrangeHRM

Test orange hrm website login functionality

Scenario: Verify login for orange hrm
	Given User is on the orange hrm login page
	When User enters "<usrname>" and "<passwd>" in  the text fields
	When User clicks on submit button
	Then User is navigated home page

Examples: 
| usrname | passwd   |
| Admin   | admin123 |

Scenario: Verifying login for orange hrm
	Given User is on the orange hrm login page
	When User enters wrong "<usrname>" and "<passwd>" in  the text fields
	When User clicks on submit button
	Then User gets displayed an error message 

Examples: 
| usrname | passwd   |
| Admin   | admin234 |