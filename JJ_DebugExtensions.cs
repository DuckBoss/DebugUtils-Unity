using UnityEngine;
using System;

namespace JJ_Debug {
	public static class DebugUtils {

		//Prints the message and the current date/time on a new line...
		public static void LogWithTime(object message) {
			Debug.Log(message + "\n" + string.Format("<color=green>{0}</color>", System.DateTime.Now));
		}

		//Prints the message as an Error and the current date/time on a new line...
		public static void LogErrorWithTime(object message) {
			Debug.LogError(message + "\n" + string.Format("<color=red>{0}</color>", System.DateTime.Now));
		}

		//Prints the message as a Warning and the current date/time on a new line...
		public static void LogWarningWithTime(object message) {
			Debug.LogWarning(message + "\n" + string.Format("<color=yellow>{0}</color>", System.DateTime.Now));
		}

		//Clears Errors from the console...
		public static void ClearErrorLogs() {
			Debug.ClearDeveloperConsole();
		}

		//Modifies a string to a designated color...
		public static string Color(this string message, string color) {
			return string.Format("<color={0}>{1}</color>", color, message);
		}
		//Modifies a string to a bold format...
		public static string Bold(this string message) {
			return string.Format("<b>{0}</b>", message);
		}
		//Modifies a string to an italics format...
		public static string Italics(this string message) {
			return string.Format("<i>{0}</i>", message);
		}
		//Modifies a strings size...
		public static string Size(this string message, int size) {
			return string.Format("<size={0}>{1}</size>", size, message);
		}
		//Modifies a string to the Important color...
		public static string MarkImportant(this string message) {
			return string.Format("<color=blue>{0}</color>", message);
		}
		//Modifies a string to the Warning color...
		public static string MarkWarning(this string message) {
			return string.Format("<color=yellow>{0}</color>", message);
		}
		//Modifies a string to the Error color...
		public static string MarkError(this string message) {
			return string.Format("<color=red>{0}</color>", message);
		}
		//Modifies a string to the Notice color...
		public static string MarkNotice(this string message) {
			return string.Format("<color=green>{0}</color>", message);
		}
		//Adds Barrier/Seperator Line to a string...
		public static string BarrierLine(this string message) {
			return string.Format("{0}\n------------------------\n", message);
		}
	
	}
}
