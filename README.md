## Specs

1) User inputs a single word (first input) _String_
2) User inputs multiple words (second input) _String_
3) Program splits second input into an array of Strings. _EX: input "Hello there cat" output { "Hello", "there", "cat" }_
4) Program checks if any words from second input match the word from the first input.
5) Program returns the number of exact word matches to User

## More detailed Specs

1) Program asks User to input a word.

2) User inputs "cat" string
  Output: cat is displayed in command prompt

3) Program asks User to input several words, separated by spaces (spaces will determine what is a word to the program)

4) User inputs "The cat chased the mouse outside. There was another cat and both got into a catfight."
  Output: the above input is displayed in the command prompt
  _This second input shows that only exact matches to first input will count while excluding examples of later considerations(see below)_

5) Program will return the number of times "cat" appears. Only exact matches. "catfight" will not count.
  Output: "cat" appears 2 times


## Later Considerations:

User enters capitalization. EX:  "Cat" or "CAT"
User enters punctuation. EX: "cat." or " "cat" " (in quotes)


# _Word Counter Program_

#### _Week 6 Independent Project for Epicodus, 9.7.2018_

#### By _**Catherine Bradley**_

## Description

_This is a C# program, run in command prompt, designed to demonstrate my skill writing C# code and using MS Testing by following BDD._

_Word Counter Program asks the User to enter a word and then asks the User to enter a sentence. The program returns a number representing how frequently the first word appeared in the sentence._

### Specifications

* _1) User enters a word. (first input)_
* _2) User enters a sentence. (second input)_
* _3) Program returns a number representing how frequently first input was found in second input._

  * _Example Input(first): "cat"_
  * _Example Input(second): "Hello there cat"_
  * _Example Output: 1_

## Setup/Installation Requirements

* _Clone this repository_
* _Navigate to WordCounter.Solution/WordCounter/Models_
* _type: mcs WordCounter.cs; mono WordCounter.exe_

## Known Bugs

* _None_

## Support and contact details

_For feedback, please contact Catherine Bradley at catherinetybradley@gmail.com_

## Technologies Used

* _C#_
* _Mono_
* _MS Test_

### Legal

*NA*
