Feature: EmployeeFeature

Scenario: Create employee record with valid details
	Given I logged into warehouse portal successfully
	When I navigate to employee page
	And I create a new employee record
	Then The record should be created successfully
