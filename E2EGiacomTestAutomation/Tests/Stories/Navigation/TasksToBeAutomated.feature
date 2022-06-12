Feature: TasksToBeAutomated
	Giacom tasks which should be automated.
	As site user
	I want to be able to work with landing page

Background: 
	Given I open The Internet page
		And I am on main page after logging in

@Logout
Scenario: User log out paths
	When I log out
	Then I can see page with header 'Login Page'
	#I cannot reach landing page without login -> two steps (action and verification)
	When I try to get to main page without login
	Then I can see error message with text 'You must login to view the secure area!'
		And I can see page with header 'Login Page'
	#Combinations of wrong username/password
	#Could be used scenarion outline with examples, but this would also run the logout part (not necessary)
	When I login with 'wrong' username and 'bluebird' password
	Then I can see error message with text 'Your username is invalid!'
	When I login with 'admin' username and 'wrong' password
	Then I can see error message with text 'Your password is invalid!'
	When I login with ' ' username and 'bluebird' password
	Then I can see error message with text 'Your username is invalid!'
	When I login with 'admin' username and ' ' password
	Then I can see error message with text 'Your password is invalid!'


@DOM
Scenario: Challenging DOM
	When I click on link 'Challenging DOM'
	Then I can see page with header 'Challenging DOM'
		And I can see correct values in rows
		| columnName | row | value         |
		| Sit        | 3   | Definiebas2   |
		| Amet       | 7   | Consequuntur6 |
		| Amet       | 8   | Consequuntur7 |