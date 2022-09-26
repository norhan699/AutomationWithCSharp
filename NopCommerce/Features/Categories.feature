Feature: Choose different Categories dynamically

Scenario: Choose Notebooks from Computers

Given I had navigated to home page
When  I hover over the Computers Category
And   I click on Notebooks from the selected list
Then  I should be navigated to Notebooks page  


Scenario: Choose Camera & Photo from Electronics

Given I had navigated to home page
When  I hover over the Electronics Category
And   I click on Camera from the selected list
Then  I should be navigated to Camera page 


Scenario: Go directly to Digital downloads

Given I had navigated to home page
When  I click on Digital downloads Category
Then  I should be navigated to Digital downloads page  

Scenario: Go directly to Electronics > Cell phones

Given I had navigated to home page
When  I select Electronics > Cell phones from the top menu
Then  I should be navigated to Cell phones page 
When  I go back
And   Forward again
Then  I should be navigated to Cell phones page 

Scenario: Go directly to Digital downloads in one step

Given I had navigated to home page
When  I select Digital downloads from the top menu
Then  I should be navigated to Digital downloads page
