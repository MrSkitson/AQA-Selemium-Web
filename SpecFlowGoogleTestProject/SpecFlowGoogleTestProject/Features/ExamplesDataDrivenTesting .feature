Feature: Examples Data Driven Testing

Search for the Love you Baby song on Google

@LoveYouBaby
Scenario Outline: Examples Data Driven Testing


	Given Open the browser
	When  Enter URL
	Then Search with <searchKey>
	Examples: 
	| searchKey |
	| song by Love you Baby|
	| best song by Love you Baby|