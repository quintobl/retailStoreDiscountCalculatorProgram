# retailStoreDiscountCalculatorProgram
Windows form application that calculates discounts for employees of a retail store, written in Visual Basic, for IT 101 (Programming 1) course at Cincinnati State

Test 2
Problem Statement
You have been asked to write a program for a retail store that will allow them to calculate discounts for their employees when they buy items. Discounts are based on
number of years worked as well as if the employee is a manager or hourly employee. They are also allowed no discount once they have received $200 in discounts for the year. 
INPUT
The application must be able to collect the following “required” information for each employee:
1.	Name (required)
2.	Number of years employed (required, numeric, >0)
3.	Total amount of previous purchases before discount (required, numeric, >=0)
4.	Employee status (hourly employee or manager)
5.	Total of today’s purchase(required, numeric, >=0)

OUTPUT
	There are two distinct areas required for output:
1.	For each employee display the following:
a.	Name 
b.	Employee discount percentage
c.	YTD Amount of discount in dollars 
d.	Total purchase today before discount
e.	Employee discount this purchase
f.	Total with discount 
2.	Calculate the total for all employees for today’s date
a.	Total before discount for the day
b.	Total after discounts applied

PROCESS
 
Employee discount standard

Years of Employment	Management	Hourly
0 Years	0%	0%
1-3 Years	20%	10%
4-6 Years	24%	14%
7-10 Years	30%	20%
11-15 Years	35%	25%
More than 15 Years	40%	30%
	
YTD discount in dollars = total purchase before today * discount

Employee discount this purchase: total purchase today * discount if < $200. If over $200 previously no discount. If less than $200 prior to today but today takes them
over $200 then only allow the amount to get them to $200.

Total with discount: Total * discount allowed

COMMAND BUTTONS
	
1.	Calculate-Calculates each employees total with discount and displays item # 1 above

2.	Next Employee-clears the employee input so the next employee sale can be entered

3.	Discount Summary-Displays the summary items from item # 2 above for all employees each day (daily totals)

4.	Exit
 
Instructions: 
•	Write the program based on your design that adheres to all requirements (65 points) that produces the correct output based on the test cases and expected results. 
•	Document your program (10 points). 
•	Use proper naming conventions (Hungarian notation) for all controls and variables (10 points) that will be referenced in code. 
•	Use named constants for max amount and discounts in chart. (5 points). 
•	Ensure your form is well designed by adhering to the following (10 points): 
•	Everything is aligned.  
•	No wasted space on the form. 
•	Ensure buttons are same size and the group is centered. 
•	No misspellings. 
•	Focus is put to the correct control upon clearing. 



