using UnityEngine;

namespace RMC.IntroToUnity.Demos.ScriptableObjects.B
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Show off the data type with 
	/// a custom "Execute" method within.
	/// </summary>
	public class ScriptableObjectAbilitiesDemo : MonoBehaviour
	{
		//  Properties -----------------------------------

		//  Fields ---------------------------------------
		[SerializeField]
		private BaseAbilitySO _mySO = null;

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------
		protected void Awake()
		{
			// Use Custom Data Values
			Debug.Log($"Awake()");
			Debug.Log($"_mySO.Damage = {_mySO.Damage}");
			Debug.Log($"_mySO.DisplayName = {_mySO.DisplayName}");

			// Use Method Implementation
			_mySO.Execute();
		}

		//  Other Methods --------------------------------

		//  Event Handlers -------------------------------
	}
}