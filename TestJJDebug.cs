using UnityEngine;
using JJ_Debug;

public class TestJJDebug : MonoBehaviour {

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

}
