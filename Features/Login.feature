Feature: Login

Tests on login page

@Authentication
Scenario: Registered user attempts to log in 
	Given the user is on the Login page
	Then the page title should be Log in
	When the user enters '+7 (950) 000-68-68' in the phone field
	And the user enters 'Password!' in the password field
	And the user clicks on the log in button
	Then the user should get a success message


	Scenario: Try to login without data 
	Given the user is on the Login page
	Then the page title should be Log in
	When the user enters '' in the phone field
	And the user enters '' in the password field
	And the user clicks on the log in button
	Then the user should get error message about required field phone
	And the user should get error message about required field password

	Scenario: Try to attempt to enter invalid values in phone input
	Given the user is on the Login page
	Then the page title should be Log in
	When the user enters 'inv!$//' in the phone field
	And the user clicks on the log in button
	Then the user should get error message incorrect phone

	Scenario: Attempting to login as an unregistered user
	Given the user is on the Login page
	Then the page title should be Log in
	When the user enters '+7 (950) 000-68-68' in the phone field
	And the user clicks on the log in button
	Then the user should get error message about not registered namber

	Scenario: Attempting to enter less than six characters in the password field
	Given the user is on the Login page
	Then the page title should be Log in
	When the user enters '1234' in the password field
	And the user clicks on the log in button
	Then the user should get error message about not registered namber

	Scenario: Entering the password with spaces
	Given the user is on the Login page
	Then the page title should be Log in
	When the user enters '  123 ' in the password field
	And the user clicks on the log in button
	Then the user should get error message about space charachters

	Scenario: Checking the transition to the recovery page
	Given the user is on the Login page
	Then the page title should be Log in
	When the user clicks on the reset password button
	Then the user is on reset password page

	Scenario: Checking the transition to the registration page
	Given the user is on the Login page
	Then the page title should be Log in
	When the user clicks on the sign-up button
	Then the user is on sign-up page

	Scenario: Checking for the correct greeting
	Given the user is on the Login page
	Then the page title should be Log in
	And the page title should be greeted according to the time