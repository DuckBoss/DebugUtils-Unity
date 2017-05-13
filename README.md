# DebugUtils-Unity
- A small script that contains useful debug methods as well as string rich text modifiers.

## Installation :
- Import both scripts into the projects asset folder.

## Usage : 
```
void Start () {
	string item = "Debug Test!";
	item.Color("cyan");
	item.Size(12);

	DebugUtils.LogWithTime(item);
	DebugUtils.LogWarningWithTime(item);

	item.MarkImportant();
	DebugUtils.LogWithTime(item);

	item.MarkWarning();
	DebugUtils.LogWithTime(item);
}
```
![](https://cloud.githubusercontent.com/assets/20238115/26022243/f4132464-376d-11e7-9dd3-a71893946a07.png)


## Extra Information:
------------------------------
- Check the 'TestJJDebug.cs' script for an example.
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
