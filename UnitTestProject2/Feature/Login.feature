Feature: login

@smoke @positive
Scenario: Check login feature with correct credentials
Given  I had navigated to home page
And  I see the application opened 
When  I clicked the Login link 
When  I enetred the username and password 
| Username | Password |
| Norhan   | N@rhan@0 |
Then  I clicked login
Then I should see my name with hello
When  I clicked the EmpList link
Then  I should be navigated to a list with all employees