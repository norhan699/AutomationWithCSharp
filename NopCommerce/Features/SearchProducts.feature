Feature: SearchProducts
@positive
Scenario: Search for multiple products dynamically
Given I had navigated to home page
When  I Go to search field
And   I Enter Apple as a search key
And   I Select the first choice in the drop down list
Then  I should be redirected to the first choice page

@positive
Scenario: Loop on multiple products dynamically
Given I had navigated to home page
When  I Go to search field
And   I Clear the text box
And   I Enter Apple as a search key
And   Wait for the loader spinner to disappear
Then  I assert the suggestion list
		| List                      |
		| Apple MacBook Pro 13-inch |
		| Apple iCam                |
When  I choose product Apple iCam 
Then  I should in Apple iCam page



