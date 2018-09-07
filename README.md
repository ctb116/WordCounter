# _Word Counter Program_

#### _Week 6 Independent Project for Epicodus, 9.7.2018_

#### By _**Catherine Bradley**_

## Description

_This is a C# program, run in command prompt, designed to demonstrate my skill writing C# code and using MS Testing by following BDD._

_Word Counter Program allows Users to know how many times a given word appears in a given text. Users enter text and then the program asks the User to enter a word. The program returns a number representing how frequently that word appeared in the text._

### Specifications

* _1) User enters text. (first input)_
* _2) User enters a word. (second input)_
* _3) Program returns a number representing how frequently second input was found in first input._

  * Example Input(Text): _Hello there, Cat. I love my cat! Where are you, cat? She says she has a 'cat.'_
  * Example Input(second): _cat_
  * Example Output: _"Your word 'cat' was used 4 time(s)._

_Program can account for capitalization:_
  * Example Input(Text): _cat CAT cAt CaT cAT Cat_
  * Example Input(word): _cat_
  * Example Output: _"Your word 'cat' was used 6 time(s)._

_Program can account for basic grammar_
  * Example Input(Text): _cat! cat. 'cat' cat? 'cat!'_
  * Example Input(word): _cat_
  * Example Output: _"Your word 'cat' was used 5 time(s)._

## Setup/Installation Requirements

* _Clone this repository_
* _Navigate to WordCounter.Solution/WordCounter/Models_
* _type: mcs WordCounter.cs; mono WordCounter.exe_

## Known Bugs

* _Program automatically ends after first result._
* _No error message if User enters a word with punctuation._
* _Program can not account for words with "double quotes" but can for words with 'single quotes'_
* _Users can only enter one word at a time._

## Support and contact details

_For feedback, please contact Catherine Bradley at catherinetybradley@gmail.com_

## Technologies Used

* _C#_
* _Mono_
* _MS Test_

### Legal

*NA*
