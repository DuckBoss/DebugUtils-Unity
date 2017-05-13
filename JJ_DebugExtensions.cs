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
			string coloredString = string.Format("<color={0}>{1}</color>", color, message);
			return coloredString;
		}
		//Modifies a string to a bold format...
		public static string Bold(this string message) {
			string boldedString = string.Format("<b>{0}</b>", message);
			return boldedString;
		}
		//Modifies a string to an italics format...
		public static string Italics(this string message) {
			string italicsString = string.Format("<i>{0}</i>", message);
			return italicsString;
		}
		//Modifies a strings size...
		public static string Size(this string message, int size) {
			string sizeString = string.Format("<size={0}>{1}</size>", size, message);
			return sizeString;
		}
		//Modifies a string to the Important color...
		public static string MarkImportant(this string message) {
			string importantString = string.Format("<color=blue>{0}</color>", message);
			return importantString;
		}
		//Modifies a string to the Warning color...
		public static string MarkWarning(this string message) {
			string importantString = string.Format("<color=yellow>{0}</color>", message);
			return importantString;
		}
		//Modifies a string to the Error color...
		public static string MarkError(this string message) {
			string importantString = string.Format("<color=red>{0}</color>", message);
			return importantString;
		}
		//Modifies a string to the Notice color...
		public static string MarkNotice(this string message) {
			string importantString = string.Format("<color=green>{0}</color>", message);
			return importantString;
		}
	
	}
}
