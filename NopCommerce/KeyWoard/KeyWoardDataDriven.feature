Feature: Excel

Scenario: Add many items to the cart and assert all cart details from excel file
Given  I had navigated to home page
When   I select Electronics > Cell phones from the top menu
And    I added 2 products in the cart 
And    I go to shopping cart page 
Then   I assert the image of the product in both pages using Excel sheet                                                                                     
And    I assert the name of the product using Excel sheet
And    I assert the price of the product according to quantity using Excel sheet
And    I assert the total price using Excel sheet