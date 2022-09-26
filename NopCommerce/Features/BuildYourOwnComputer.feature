Feature: Customized Computer

Scenario: Build Your Own Computer
Given  I had navigated to home page
When   I clicked on Add To Cart of Build Your Own Computer
Then   I have redirected to Build Your Own Computer Page
When   I choose processor 2.5 from drop down list
And    I choose RAM 4 GB
And    I choose HDD 320 GB
And    I choose OS Home
And    I choose SW Acrobat
Then   Total price should be $1,345.00
