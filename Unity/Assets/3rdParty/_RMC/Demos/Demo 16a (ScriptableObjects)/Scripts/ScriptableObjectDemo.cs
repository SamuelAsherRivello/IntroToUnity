using UnityEngine;

namespace RMC.IntroToUnity.Demos.ScriptableObjects.A
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Show off the data type
	/// </summary>
	public class ScriptableObjectDemo : MonoBehaviour
	{
		//  Properties -----------------------------------

		//  Fields ---------------------------------------
		[SerializeField]
		private MySO _mySO = null;

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------
		protected void Awake()
		{
			// Use Custom Data Values
			Debug.Log($"Awake()");
			Debug.Log($"_mySO.Age = {_mySO.Age}");
			Debug.Log($"_mySO.DisplayName = {_mySO.DisplayName}");
		}

		//  Other Methods --------------------------------

		//  Event Handlers -------------------------------
	}
}