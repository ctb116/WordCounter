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
