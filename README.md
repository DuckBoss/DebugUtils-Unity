# DebugUtils-Unity
- A small script that contains useful debug methods as well as string rich text modifiers.

## Installation :
- Import both scripts into the projects asset folder.

## Usage : 
```
void Start () {
	// The string to debug...
	string item = "Debug Test 1!";
	// Modify the string color...
	item = item.Color("red");
	// Modify the string size...
	item = item.Size(12);
	// Debug the object with time...
	DebugUtils.LogWithTime(item);
	// Debug the object as a warning with time...
	DebugUtils.LogWarningWithTime(item);


	string item2 = "Debug Test 2!";
	// Modify the color to Important color...
	item2 = item2.MarkImportant();
	DebugUtils.LogWithTime(item2);


	string item3 = "Debug Test 2!";
	// Modify the color to Warning color...
	item3 = item3.MarkWarning();
	DebugUtils.LogWithTime(item3);
}
```
![](https://cloud.githubusercontent.com/assets/20238115/26022319/d6c98ec8-376f-11e7-8ff6-c2f980e0e1f9.PNG)


## Extra Information:
------------------------------
- Check the 'TestJJDebug.cs' script for a working example.
- The script is fully documented.




# License:
------------------------------
MIT License

Copyright (c) [2017] [Jason Jerome]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


Basically this license gives permissions for:
- Commercial Use
- Distribution
- Modification
- Private Use
