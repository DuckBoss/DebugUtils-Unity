using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JJ_Debug;

public class TestJJDebug : MonoBehaviour {

	// Use this for initialization
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

}
