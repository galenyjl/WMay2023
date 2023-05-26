Feature: Employee

Scenario: Create employee record with valid details
	Given I logged into warehouse portal successfully
	When I navigate to employee page
	And I create a new employee record
	Then The record should be created successfully
	
Scenario Outline: Edit existing employee record with valid details
	Given I logged into warehouse portal successfully
	When I navigate to employee page
	And I update '<FirstName>', '<LastName>' and '<Usernname>' on an existing employee record
	Then The record should have the updated '<FirstName>', '<LastName>' and '<Usernname>'

Examples: 
| FirstName | LastName  | Usernname   |
| abc       | def       | abcdef      |
| 123       | Keybooard | 123Keyboard |
| Any       | Mouse     | AnyMouse    |