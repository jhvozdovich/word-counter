# **Word Counter**

### _Intermediate C# and Testing - Week 9 Project at Epicodus_

#### Author: **_Jessica Hvozdovich_**
#### May 15, 2020

### Description

_The purpose of this project is to create a C# console application that accepts string inputs of a word and a sentence from the user. It demonstrates the use of Behavior Driven Development and Test Driven Development using C# with the MSTest unit testing framework._

### Instructions for use:

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Begin the program with the command dotnet run.

### Known Bugs

No bugs have been identified at the time of this update.

### Support and Contact Information

Please contact me with any suggestions or questions at jhvozdovich@gmail.com. Thank you for your input!  
_Have a bug or an issue with this application? [Open a new issue](https://github.com/jhvozdovich/word-counter/issues) here on GitHub._

### Technologies Used

* C#
* MSTest
* .NET Core
* Git and GitHub

### Specs
| Spec | Input | Output | Reasoning |
| :------------- | :------------- | :------------- | :------------- |
| **Count single character inputs** | User Input:"Word: a, Sentence: a” | Output: “1” | Selected to ensure the code can match the most minimal input and correctly increase a counter |
| **Count single character inputs with different capitalization** | User Input:"Word: a, Sentence: A” | Output: “1” | Selected to ensure the code can adapt to capitalization variations |
| **Does not count single character inputs with different letters** | User Input:"Word: a, Sentence: b” | Output: “0” | Selected to ensure the code does not count non-matches |
| **Count single word inputs** | User Input:”Word: cat, Sentence: cat” | Output: “1” | Selected to ensure the code is able to match a series of multiple characters |
| **Count single word inputs with different capitalization** | User Input:”Word: cat, Sentence: Cat” | Output: “1” | Selected to ensure the code is able to match a series of multiple characters with capitalization variations |
| **Does not count single word inputs with different words** | User Input:"Word: cat, Sentence: bat” | Output: “0” | Selected to ensure the code does not count non-matches with more complicated inputs |
| **Count two word inputs** | User Input:”Word: cat, Sentence: cat cat” | Output: “2” | Selected to ensure the code is able to recognize spaces as word separators and continue to correctly increase the counter |
| **Count two word inputs, excluding non matches** | User Input:”Word: cat, Sentence: cat bat” | Output: “1” | Selected to ensure the code is able to recognize spaces as word separators and continue to correctly increase the counter, excluding non matches |
| **Count sentence inputs, excluding non-matches** | User Input:”Word: cat, Sentence: This cat named Zora is my favorite cat in the world!” | Output: “2” | Selected to ensure the code is able to ignore non-matching words |
| **Does not count words that partially contain the word of interest** | User Input:”Word: cat, Sentence: cathedral” | Output: “0” | Selected to ensure the code is able to ignore non-matching words that contain the word of interest |
| **Count words that are adjacent to punctuation at the end of a word** | User Input:”Word: cat, Sentence: Zora is my favorite cat!” | Output: “1” | Selected to ensure the code is able recognize punctuation as a word separator |
| **Count words that are adjacent to punctuation at the beginning of a word** | User Input:”Word: cat, Sentence: (Cat or dog)” | Output: “1” | Selected to ensure the code is able recognize punctuation as a word separator regardless of position |
| **Count words that are adjacent to punctuation at the beginning and end of a word** | User Input:”Word: cat, Sentence: What is a 'cat'” | Output: “1” | Selected to ensure the code is able recognize surrounding punctuation as a word separator |
| **Count words that are adjacent to multiple characters of punctuation** | User Input:”Word: cat, Sentence: The question is: "Does everybody want to be a cat?" ” | Output: “1” | Selected to ensure the code is able to separate multiple punctuation characters as a word separator |
| **Does not count words that are adjacent to punctuation for possessives** | User Input:”Word: cat, Sentence: This is my cat's toy mouse.” | Output: “0” | Selected to ensure the code is able recognize possessive words as a different word |
| **Count words that are adjacent to punctuation for quotation marks** | User Input:”Word: cat, Sentence: The words to the song are: 'Everybody wants to be a cat'” | Output: “1” | Selected to ensure the code is able recognize non-possessive quotes as a word separator |
| **Does not accept empty inputs** | User Input:”Word: ” | Output: “Please enter a word” | Selected to account for invalid blank entries |
| **Does not accept entries with spaces** | User Input:”Word: cat dog” | Output: “Please enter a single word without spaces” | Selected to account for invalid entries or multiple words |
| **Displays warning for words ending with special characters** | User Input:”Word: cat!” | Output: “did you mean 'cat'?” | Selected to account for possible user entry punctuation mistakes |
| **Gives option for user to remove all alphabetical characters from word input** | User Input:”Word: cat5s” | Output: “would you like to remove non alphabetical characters?” | Selected to account for possible user entry mistakes, but not automatically correct if they are intentional |
| **Gives option for user to remove punctuation at the beginning and ending of a word** | User Input:”Word: cat!” | Output: "would you like to remove punctuation” | Selected to account for possible user entry punctuation mistakes, but not automatically correct if they are intentional |

#### Resources

[ASCII Cat](https://www.asciiart.eu/animals/cats)

#### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Jessica Hvozdovich_**
