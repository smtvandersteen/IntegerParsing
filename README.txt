Problem to solve:
Input provided:
Two integer parameters between 1 and 999, inclusive.
	Note:
	Prompts in the Console twice. Once for each input value. Input is validated and if it is determined to be invalid it will not continuing until valid input is provided for each prompt.

Output to provide:
Dictionary<int, int> whose keys are all the integers between the two input parameters, inclusive, and whose values are the number of occurrences of the letter ‘e’ contained in the English spelling of the corresponding key.
	Note:
	Output is printed to Debug.WriteLine() in the form of:
	Integer: 6. Number of e's in string representation: 0
	Integer: 7. Number of e's in string representation: 2
	Integer: 8. Number of e's in string representation: 1
	Integer: 9. Number of e's in string representation: 1
	Integer: 10. Number of e's in string representation: 1
	Integer: 11. Number of e's in string representation: 3

Example:
If we execute your method, `YourMethod(6, 10)`, we expect to get a dictionary with the following (key, value) pairs:
(6, 0)      (“six” has no ‘e’s)
(7, 2)      (“seven” has two ‘e’s)
(8, 1)      (“eight” has one ‘e’)
(9, 1)      (“nine” has one ‘e’)
(10, 1)   (“ten” has one ‘e’)

** No external libraries are to be used **


