# Hello World But Stupid
Ever wanted to write Hello World for C++, but in a fun, unique way? This program is for you. Baffle your colleagues with this meme of a tool!
# What Is This Thing?
Hello World But Stupid transmutates this:
```cpp
#include <iostream>

int main ( )
{
	std :: cout << "SomeString" ;
	return 0 ;
}
```
Into this:
```cpp
#include <iostream>

#define memes int
#define Memes main
#define meMEs (
#define meMES )
#define MeMeS {
#define MeMes std
#define mEMes ::
#define MeMES cout
#define mEMEs <<
#define MEmES "memes"
#define mEMES ;
#define memeS return
#define meMeS 0
#define MemES ;
#define MEmes }

memes Memes meMEs meMES MeMeS
MeMes mEMes MeMES mEMEs MEmES
mEMES memeS meMeS MemES MEmes
```
In other words, every token in the above hello world snippet is transformed into a ``#define`` as a permutation of the string of your choosing. The string in question can be anything at least 4 characters long to allow for enough permutations.
Also, it needs to be possible to make enough permutations through uppercasing and lowercasing the string in question, and it cannot contain a space (preprocessor definitions can't have spaces, unfortunately).
Of course, it does replace what is printed, ``SomeString``, with your value.
# But why?
I saw a post on r/ProgrammingHumor, came up with this idea as a result, and thought it would be funny. Credit goes to ``u/x32byTe`` for the inspiring post in question.
# This is stupid.
No, actually, it's amazing.