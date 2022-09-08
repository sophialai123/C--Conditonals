## Introduction to Logic in C# 
Comparison operators include:

- Equals `==`: returns true if the value to the left is equal to the value to the right.
- Inequality operator `!=`: returns true if the two values are not equal.
- Less than `<`: returns true if the value to the left is less than the value to the right.
- Greater than `>`: returns true if the value to the left is more than the value to the right.
- Less than or equal to `<=`: returns true if the value to the left is less than or equal to the value on the right.
- Greater than or equal to `>=`: returns true if the value to the left is more than or equal to the value to the right.

In addition to comparing integers, we can also compare variables, strings, and even boolean values:

```
bool answer = (true == false);
Console.WriteLine(answer); //prints False
```


```
using System;

namespace ComparisonOperators
{
  class Program
  {
    static void Main(string[] args)
    {
    double timeToDinner = 4;
    double  distance = 95;
    double rate = 30;
 double tripDuration = distance / rate;
 bool answer = tripDuration <= timeToDinner;
 Console.WriteLine(answer);
    }
  }
}

```
---
## Truth Table
Logical operators include:

`AND &&:` Both expressions are evaluated and will return True only if both expressions evaluate to True. Otherwise, it will return False.

```
`bool andExample = ((4 > 1) && (2 < 7)); 
// (True AND True) evaluates to True`

```

`OR ||:` Both expressions are evaluated and will return True if at least one of the expressions evaluates to True. Otherwise, it will return False.

```
bool orExample = ((8 > 6) || (3 > 6));
// (True OR False) evaluates to True
```

`NOT !:` An expression, no matter its logical value, evaluates to its opposite. What is True becomes False and what is False becomes True.

```
bool notExample = !(1 < 3);
// NOT (True) evaluates to False
```

---
## Logical Operators
As we saw in the truth table, a Boolean expression that uses logical operators can be as simple as evaluating two boolean values:
`bool answer = true && false; // evaluates to False`

But more often, Boolean expressions are extremely complex. Rather than determining if one relationship is true or false, we can evaluate several expressions by connecting them with logical operators and then determining the validity of the overall expression.

```
bool answer = (9 < 3) || (100 < 45); // evaluates to False
bool another = ((3439 > 40) && (1 < 3)) || answer; // evaluates to True

```

---
## Introduction to Conditional Statements
We’ll look at a couple of different structures that use Boolean logic to control the flow of our programs, including:

If statements
If…Else… statements
Else if statements
Switch statements
Ternary Operators

---
## If Statements
The most basic conditional statement is an if statement. An if statement executes a block of code if specified condition is true.

In C#, we write an if statement using the following syntax:

```
string color = "blue";
 
if (color == "blue")
{
  // this code block will execute only if the value of color is 
  // equivalent to "blue"
  Console.WriteLine("color is blue");
}
```

When writing an if statement, make sure to pay attention to:

Parentheses: we place the boolean expression that the if statement is evaluating in parentheses ().
Braces: after the boolean expression, we write a set of braces {}. Write the code that will execute if the boolean expression evaluates to true inside these braces.
Indentation: while whitespace won’t impact our program, it is convention to indent the code inside the braces by two spaces.

---
## If...Else... Statements
An else clause can be added to an if statement to provide code that will only be executed if the if condition is false.

```
string color = "red";
 
if (color == "blue")
{
  // this code block will execute only if the value of color is 
  // equivalent to "blue"
  Console.WriteLine("color is blue");
} 
else 
{
  // this code block will execute if the value of color is 
  // NOT equivalent to "blue"
  Console.WriteLine("color is NOT blue");
}
```

---
## Else If Statements
In C#, we write an if..else if... statement using the following syntax:

```
string color = "red";
 
if (color == "blue")
{
  // this code block will execute only if the value of color is 
  // equivalent to "blue"
  Console.WriteLine("color is blue");
} 
else if (color == "red")
{
  // this code block will execute if the value of color is 
  // equivalent to "red"
  Console.WriteLine("color is NOT blue");
} 
else // this is optional
{
  // this code block will execute if the value of color is 
  // NOT equivalent to "blue" OR "red"
  Console.WriteLine("color is NOT blue OR red");
}
```

---
## Switch Statements
If it’s necessary to evaluate several conditions with their own unique output, a switch statement is the way to go. Switch statements allow for compact control flow structures by evaluating a single expression and executing code blocks based on a matched case.




```
string color;
 
switch (color)
{
   case "blue":
      // execute if the value of color is "blue"
      Console.WriteLine("color is blue");
      break;
   case "red":
      // execute if the value of color is "red"
      Console.WriteLine("color is red");
      break;
   case "green":
      // execute if the value of color is "green"
      Console.WriteLine("color is green");
      break;
   default:
      // execute if none of the above conditions are met
      break;
}
```
Cases: rather than writing out each condition, if we’re evaluating one value we use cases to specify different potential values.
Braces: rather than each case having its own code block, the entire statement lives within one set of braces {}.
Colons: to distinguish between different cases, we state the case value, followed by a colon :. The code that should execute if that case is met follows.
Break: Each case code needs to end with a break keyword.
Default: Every switch statement needs a default case.

---
## Ternary Operators
The ternary operator allows for a compact syntax in the case of binary decisions. Like an if...else statement, it evaluates a single condition and executes one expression if the condition is true and the second expression otherwise.

```
string color = "blue";
string result = (color == "blue") ? "blue" : "NOT blue";
 
Console.WriteLine(result);
```