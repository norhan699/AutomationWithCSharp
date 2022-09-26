Feature: ShoppingCart

Scenario: Add many items to the cart ans assert all cart details
Given  I had navigated to home page
When   I select Electronics > Cell phones from the top menu
And    I added to the cart 
		| Product           | quantity |
		| HTC One Mini Blue | 2        |
		| Nokia Lumia 1020  | 1        |
And    I go to shopping cart page 
Then   I assert the image of the product in both pages
	    | Product           | Image Value( Cell phones page)     | Image Value( Shopping cart page ) |
	    | HTC One Mini Blue | 0000042_htc-one-mini-blue_415.jpeg | 0000042_htc-one-mini-blue_80.jpeg |
	    | Nokia Lumia 1020  | 0000044_nokia-lumia-1020_415.jpeg  | 0000044_nokia-lumia-1020_80.jpeg  |                                                                                      
And    I assert the name of the product
		| Product           | 
		| HTC One Mini Blue | 
		| Nokia Lumia 1020  | 
And    I assert the price of the product according to quantity
		| Product           | quantity | price     |
		| HTC One Mini Blue | 2        | 100.00    |
		| Nokia Lumia 1020  | 1        | 349.00    |
And    I assert 549.00 to be the total price 