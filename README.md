# [Plus Minus](https://www.hackerrank.com/challenges/staircase/problem?isFullScreen=true)

## Problem
Staircase detail

This is a staircase of size $n = 4$
Example
```
   #
  ##
 ###
####
```

Its base and height are both equal to . It is drawn using # symbols and spaces. The last line is not preceded by any spaces.

Write a program that prints a staircase of size .

## Solution
```
public void staircase(int n)
{
    for (int i = 0; i < n; i++)
    {
        string space = new(' ', n - i - 1);
        string hastag = new('#', i + 1);
        string result = space + hastag;
        Console.WriteLine(result);
    }
}
```

## 🚀 About Me
I'm a full stack developer and IT enthusiast. Skilled in Programming, Teamwork, Software Development, and Project Management. Strong information technology professional with a Bachelor of Technology - BTech focused in Information Technology from Institut Teknologi Telkom Surabaya.




## Authors

- [@me](https://github.com/agisx)
