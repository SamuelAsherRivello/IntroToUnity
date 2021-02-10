using UnityEngine;

namespace RMC.IntroToUnity.Demos.ScriptableObjects
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
			Debug.Log("Awake() _mySO.Age=" + _mySO.Age);
			Debug.Log("Awake() _mySO.FirstName=" + _mySO.FirstName);
		}

		//  Other Methods --------------------------------

		//  Event Handlers -------------------------------
	}
}