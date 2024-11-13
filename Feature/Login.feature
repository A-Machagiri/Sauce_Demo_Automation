Feature: Login Functionality

  Scenario: Successful Login
    Given I am on the login page
    When I enter valid credentials
    Then I should be redirected to the inventory page

  Scenario: Invalid Login
    Given I am on the login page
    When I enter invalid credentials
    Then I should see an error message

  Scenario: Locked-Out User
    Given I am on the login page
    When I enter credentials for a locked-out user
    Then I should see a lockout message