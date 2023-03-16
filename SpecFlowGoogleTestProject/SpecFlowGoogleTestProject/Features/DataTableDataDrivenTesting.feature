Feature: DataTable Data Driven Testing

Search for the Love you Baby song on Google

@LoveYouBaby
Scenario: DataTable Data Driven Testing


	Given Open the browser
	When  Enter the  URL
	Then Enter search keyword in Google
	Examples: 
	| searchKey |
	| song by Love you Baby|
	| best song by Love you Baby|