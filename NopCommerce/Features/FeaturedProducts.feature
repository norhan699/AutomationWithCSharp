Feature: FeaturedProducts
@positive
Scenario: Check Featured Products prices
Given   I had navigated to home page 
When    I scroll down to Featured products
Then    I choose Product name I Assert its price	 
	 | ProductName                        | Price     | 
	 | Build your own computer            | $1,200.00 |
	 | Apple MacBook Pro 13-inch          | $1,800.00 |
	 | HTC One M8 Android L 5.0 Lollipop  | $245.00   |
	 | $25 Virtual Gift Card              | $25.00    |
