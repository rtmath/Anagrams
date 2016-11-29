# _Anagrams!_

**_By Erik and Ryan_**

### _Description_

_This program will allow users to enter a word and a list of words to test against and check for anagrams_

### _Setup_

_Requires Windows_

* _Clone repository from GitHub._
* _In PowerShell, run ">dnx kestrel" and go to "localhost:5004" in your web browser._

#### _Specs for Anagram Program:_

* _Check one word against another_
 * _Inputs: "beard", "bread"_
 * _Output: "Anagrams: 'Bread' "_

* _Check one word against multiple words_
 * _Inputs: "draw", "ward, Winnie the Pooh"_
 * _Output: "Anagrams: 'draw', 'ward' "_

* _Check one word against partial matches_
 * _Inputs: "path", "hat"_
 * _Output: "Anagrams: 'hat' "_

* _Input will accept apostrophes_
 * _Inputs: "we're", "were"_
 * _Output: "Anagrams: 'were' "_

### _Technologies Used_

_C#, Nancy, Razor, Asp.Net, Xunit._
