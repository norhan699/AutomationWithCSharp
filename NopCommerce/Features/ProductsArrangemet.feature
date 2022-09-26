Feature: ProductArrangemet

Scenario: check low to high price arrangement
Given     I had navigated to home page
When      I select Electronics > Others from the top menu
And       I arrange products according to Price: Low to High 
Then      I assert the prices 

Scenario: check A to Z arrangement
Given     I had navigated to home page
When      I select Electronics > Others from the top menu
And       I arrange products according to Name: A to Z 
Then      I assert the names alphabatecal order

