using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace JJ_Debug {
	public static class DebugUtils {

		public static void LogWithTime(object message) {
			Debug.Log(message + "\n" + string.Format("<color=green>{0}</color>", System.DateTime.Now));
		}

		public static void LogErrorWithTime(object message) {
			Debug.LogError(message + "\n" + string.Format("<color=red>{0}</color>", System.DateTime.Now));
		}

		public static void LogWarningWithTime(object message) {
			Debug.LogWarning(message + "\n" + string.Format("<color=yellow>{0}</color>", System.DateTime.Now));
		}

		public static void ClearErrorLogs() {
			Debug.ClearDeveloperConsole();
		}

		public static string Color(this string message, string color) {
			string coloredString = string.Format("<color={0}>{1}</color>", color, message);
			return coloredString;
		}

		public static string Bold(this string message) {
			string boldedString = string.Format("<b>{0}</b>", message);
			return boldedString;
		}

		public static string Italics(this string message) {
			string italicsString = string.Format("<i>{0}</i>", message);
			return italicsString;
		}

		public static string Size(this string message, int size) {
			string sizeString = string.Format("<size={0}>{1}</size>", size, message);
			return sizeString;
		}

		public static string MarkImportant(this string message) {
			string importantString = string.Format("<color=blue>{0}</color>", message);
			return importantString;
		}

		public static string MarkWarning(this string message) {
			string importantString = string.Format("<color=yellow>{0}</color>", message);
			return importantString;
		}

		public static string MarkError(this string message) {
			string importantString = string.Format("<color=red>{0}</color>", message);
			return importantString;
		}

		public static string MarkNotice(this string message) {
			string importantString = string.Format("<color=green>{0}</color>", message);
			return importantString;
		}
	
	}
}
