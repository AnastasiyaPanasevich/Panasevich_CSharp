# Technical task for the traineeship candidates QA Automation 
## Task 1 Make up an algorithm 
-If the entered number is greater than 7, then print “Hello” 
-If the entered name matches “John”, then output “Hello, John”, if not, then output "There is no such name" 
-There is a numeric array at the input, it is necessary to output array elements that are multiples of 3 

## Task 2 Answer the questions
1. 1. No, I do not consider this sequence to be correct.

2. I can define next rules for a correct sequence of brackets:
   - every opening bracket must have a corresponding closing bracket of the same type,
   - they cannot overlap.

| 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13 | 14 |
|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|
| [ | ( | ( | ( | ) | ) | ( | ) | ( | ( | ) | ) | ] | ] |

It can be noticed that bracket #2 is missing a matching pair, as well as one of the final square brackets #13 or #14.

Using the rules above, the following solution can be proposed:
replace the #13 bracket with a round bracket.

Corrected sequence:

'[((())()(()))]'

This particular solution is suggested because there is also a rule of priority between different types of brackets, where in this example the square brackets are the outer closing brackets, and it does not make sense to have two pairs of closing brackets with the same operation priority.
