using System;
using System.Collections;
using UnityEngine;

namespace RMC.IntroToUnity.Demos.Coroutines
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Call code after delay
	/// </summary>
	public class CoroutineDemo : MonoBehaviour
	{
		//  Properties -----------------------------------

		//  Fields ---------------------------------------

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------
		protected void Awake()
		{
			CallMethod("Awake 1");

			StartCoroutine(CallMethodLater());

			CallMethod("Awake 2");
		}

		//  Other Methods --------------------------------

		private void CallMethod(string message)
		{
			Debug.Log("CallMethod() " + message);
		}

		private IEnumerator CallMethodLater()
		{
			yield return new WaitForSeconds(0.5f);

			Debug.Log("CallMethodLater() at time: " + Time.timeSinceLevelLoad);
		}

		//  Event Handlers -------------------------------
	}
}