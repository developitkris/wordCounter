__# Word WordCounter__
<hr>
##### This is a program that counts the number of occurrences of your input word in your input sentence.
##### 4/27/2018
##### By **Kristi Hwang**

### Description
<hr>
A website that takes a separate word and sentence from the user and returns a number of occurrences result.  Both the word and sentence can only contain alpha characters and no special characters or numbers.  The program reads through the entire word the user has inputted.  Then it looks through the entirety of the user sentence to find a match of that word.  The word can be a partial letter/s match of the user sentence and/or match an entire word in that sentence.  The repeat counter counts the number of times that match occurs and returns a numeric value as the result.  If the directions are not followed as stated, the result will be a warning message to fix your input.

### Specs
<hr>
* Tests to see if an input is entered.  Both input word and input sentence are checked to see if its filled.  If input word is filled but input word is not, it should not be valid. Input word of "i" with no input sentence, will return a result: "You have not completely filled out both required fields.  Please do so before proceeding.".
* Tests to see if both the input word and input sentence contains only alpha characters.  Any other special characters of input will not return the expected result. Entering string "0" in word "f00d" will not match the sentence "we have food for all".  The result will not even return a valid number of occurrence.  The result will be "You have not entered a valid input, please make sure you only enter alpha characters.".
* Tests for a single alpha character to match from the input word on the input sentence. The string "z" in word "z", should match "z" once in the sentence "people who study zoology".  The result should equal 1.
* Tests for a partial word to match from the input word on the input sentence.  The string "aba" in word "abacus", should match "aba" once in the sentence "looked for contraband on shipments".  The result should equal 1.
* Tests for a full word to match from the input word on the input sentence.  The string "soccer" in word "soccer", should match "soccer" once in the sentence "I like to be midfield offense when I do play soccer". The result should equal 1.
* Tests for more than one occurrence of a word match.  The string "water" in word "water", should match "water" twice in the sentence "any water sport will do, especially Waterpolo".  The result should equal 2.  

### Setup and Installation
<hr>
_1. Make sure to have Microsoft .NET Framework installed_
_2. Clone this GitHub Repository onto your computer device._
_3. In the terminal's REPL, navigate into the WordCounter folder_
_4. Once inside the WordCounter folder, build and run the website by respectively entering "dotnet build" then "dotnet run"._
_5. Enter in http://localhost:5000/ in your web browser._
_6. Once the page loads, you are ready to use the website._

### Bugs
<hr>
There are no known bugs at this time

### Technologies Used
<hr>
_C#_
_JavaScript_
_MVC_
_Razor_
_GitHub_
_Git_
_Bootstrap_
_HTML_
_CSS_

### Support
<hr>
Please feel free to leave feedback or comments.
If you are experiencing problems and/or have any other concerns you would like to notify the author of, please email Kristi Hwang at mailto:krsy3ii@yahoo.com

### Licensing
<hr>
**This software is licensed under the MIT License.**
**Copyright(c) 2018, Kristi Hwang**
