# string-manipulation
String Manipulation (C#)

Question:

String Manipulation: Sort of String

You are given N strings.

For each string, perform the following sorting operations:

1. Rearrange the alphabets in the string in terms of frequency. ¡.e. the alphabet having greater frequency comes first.
2. If two or more alphabets have the same frequency, the alphabet which is lexicographically small comes first.

Write a program to perform the above sorting operations.

Note

1. The frequency of an alphabet is the number of times an alphabet appears in a string.

Example: Consider the string aabaac; here, the frequency of a is 3, frequency of b is 1, and frequency of cis 1.

2. Lexicographic order is the way of ordering words based on the alphabetical order of English letters ¡.e. "a" is the smallest letter and "2" is the
largest letter.

 

Function Description
In the provided code snippet, implement the provided sortingOperations (.. .) method using the variables to print the output. You can write your
code in the space below the phrase "WRITE YOUR LOGIC HERE”.

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base output variable result ¡is set to a default value of -404 which can be modified. Additionally, you can add or remove these output
variables.

Input Format
The first line contains N, denoting the number of strings.

Next MN lines contain strings on which sorting operation has to be performed.

Sample Input

2 -- denotes N
abaccadcc -- denotes a string
xy DY -- denotes a string

Output Format
The output contains N lines containing strings after the sorting operation is performed.

Sample Output

ccccaaabd
xxyyz

Explanation

For the first string abaccadcc, "c" has the highest frequency.

Hence, we write c followed by "a", "b", and then "d".

Hence the output is ccccaaabd.

For the second string xyzxy, "x" and "y" both have the same frequencies.

Since "x" is lexicographically small, we write that first, followed by "y" and then "z".
Hence the output is xyzxy.

Coding Language:C+t CODE QUALITY REPORT
