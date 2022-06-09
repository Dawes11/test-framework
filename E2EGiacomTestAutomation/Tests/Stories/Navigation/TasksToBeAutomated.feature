Feature: TasksToBeAutomated
	Giacom tasks which should be automated.
	As site user
	I want to be able to work with landing page

Background: 
	Given I open The Internet page
		And I am on landing page after logging in

@Logout
Scenario: User log out paths
	When I log out
	Then I can see page with header 'Login Page'
	When I try to get to Main page without login
	Then I can see '' message