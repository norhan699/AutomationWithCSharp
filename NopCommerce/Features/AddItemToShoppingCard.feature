Feature: Shopping Card
@positive 
Scenario: Add Item To Shopping Card
Given     I had navigated to home page 
When      I scroll down to Featured products
Then      Go through Gift cards
When      You fill form data
And       click add button
Then      You should assert that the green panel appears
When      You scroll up
And       hover over the shopping card
Then      You should assert that the item to be added successfully
When      press Go to card
Then      You should assert that the item to be added successfully