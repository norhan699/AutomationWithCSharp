Feature: Registration


@smoke @positive
Scenario: Check registration feature with correct data
Given  I had navigated to home page
And  I see the application opened 
When  I clicked the Register link 
When  I enetred the username and password and confirm password and email
| Username | Password | ConfirmPassword | Email                   |
| Norhan   | N@rhan@0 | N@rhan@0        | NorhanMmedhat@gmail.com |
Then  I clicked register
Then I should see my name with hello