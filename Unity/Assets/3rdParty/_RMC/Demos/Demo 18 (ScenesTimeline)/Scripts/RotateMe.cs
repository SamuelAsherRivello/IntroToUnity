using UnityEngine;

namespace RMC.IntroToUnity.Demos.ScenesTimeline
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Rotate Every frame
	/// </summary>
	public class RotateMe : MonoBehaviour
	{
		//  Properties -----------------------------------

		//  Fields ---------------------------------------
		[SerializeField]
		private bool _isEnabled = true;

		private Vector3 _rotationSpeed = new Vector3(0, 0.5f, 0);

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------
		protected void Update()
      {
			if (_isEnabled)
         {
				transform.Rotate(_rotationSpeed);
         }				
      }

		//  Other Methods --------------------------------

		//  Event Handlers -------------------------------
	}
}