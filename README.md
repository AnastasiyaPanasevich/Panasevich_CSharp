# Technical task for the traineeship candidates QA Automation 
## Task 1 Make up an algorithm 
### Setting the logic
Three following requires and implementation of them in the programm:
> 1. If the entered number is greater than 7, then print “Hello”
>
> 2. If the entered name matches “John”, then output “Hello, John”, if not, then output "There is no such name"
>
> 3. There is a numeric array at the input, it is necessary to output array elements that are multiples of 3

The user can enter any integer number. Depending on whether the number is greater than 7, the corresponding message will be displayed.

The user can also enter alphabetic characters, which will be checked to determine whether they form the name "John". If so, the program will greet John. Otherwise the corresponding message will be displayed.

If multiple values separated by spaces are entered, the program will check whether they are integers in order to perform task 3. If the validation succeeds, the program will output an array containing only the elements that are multiples of 3, while preserving their original order.

Since no other requirements were specified, and task 3 is most reasonably performed using integers, the program warns the user if a floating-point number is entered. The program also warns the user if the entered array contains values other than integers.

### Program structure

The program consists of 6 logical parts.

```Program.cs``` is the main entry point of the application. It displays the task description, reads user input, splits it into tockens, and controls the main loop of the program including the exit when the user enters an empty line.

```InputRouter.cs``` receives the entered values and decides what should happen next based on the number and type of values. A single value is checked either it is a number or a word. Multiple values are treated as an array and sent to the logic that searches for numbers that are multiples of 3.

```InputParser.cs``` contains methods for helping to check input values. It determines whether a value looks like a floating point number, whether it is outside the integer range, or whether it contains valid characters for a name. 

```InputValidator.cs``` uses the parsed checks to determine what exactly is wrong with the input and throws an ```AppException.cs``` with a clear message for the user. This allows all validation messages to stay in one place.

```AppException.cs``` is a custom exception class used for expected input mistakes. It allows the program to separate user input errors from unexpected system errors.

```Algorithms.cs``` contains the main logic for all three tasks. It works only with validated values, performs the required operations, and returns the final result for output to ```Program.cs``` in a form of string.

#### The ability to run the received program

This program does not use any additional libraries or external tools and can be run the standard way. The entry point is ```Program.cs```. No additional configuration is required.

## Task 2 Answer the questions
1. No, I do not consider this sequence to be correct.
2. I can define next rules for a correct sequence of brackets:
   - every opening bracket must have a corresponding closing bracket of the same type,
   - they cannot overlap.

| 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13 | 14 |
|:---|---|---|---|---|---|---|---|---|---|---|---|---|---:|
| [ | ( | ( | ( | ) | ) | ( | ) | ( | ( | ) | ) | ] | ] |

It can be noticed that bracket #2 is missing a matching pair, as well as one of the final square brackets #13 or #14.
Using the rules above, the following solution can be proposed:
replace the #13 bracket with a round bracket.

Corrected sequence:
```[((())()(()))]```

This particular solution is suggested because there is also a rule of priority between different types of brackets, where in this example the square brackets are the outer closing brackets, and it does not make sense to have two pairs of closing brackets with the same operation priority.
