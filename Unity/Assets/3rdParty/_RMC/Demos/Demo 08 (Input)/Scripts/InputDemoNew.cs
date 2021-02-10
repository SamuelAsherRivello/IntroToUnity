using UnityEngine;
using UnityEngine.InputSystem;

namespace RMC.IntroToUnity.Demos.Inputs
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Input with new (2019+) system
	/// </summary>
	public class InputDemoNew : MonoBehaviour
	{
		//  Properties -----------------------------------

		//  Fields ---------------------------------------
		[SerializeField]
		private Transform _target = null;

		[SerializeField]
		private float _sensitivity = 10f;

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------

		//  Other Methods --------------------------------
		private void RotateTarget(Vector3 delta)
		{
			Vector3 delta2 = new Vector3(delta.y, - delta.x, 0);

			_target.Rotate(delta2, Space.World);
		}

		//  Event Handlers -------------------------------

		/// <summary>
		/// Accept keyboard arrow keys, gamepad, and more...
		/// </summary>
		public void OnMove(InputAction.CallbackContext context)
		{
			Vector3 moveDelta = context.action.ReadValue<Vector2>() * _sensitivity;

			//Debug.Log("OnMove() context: " + moveDelta);

			RotateTarget(moveDelta);
		}

		/// <summary>
		/// Accept mouse input and more...
		/// </summary>
		public void OnLook (InputAction.CallbackContext context)
		{
			Vector3 moveDelta = context.action.ReadValue<Vector2>() * _sensitivity;

			//Debug.Log("OnMove() context: " + moveDelta);

			RotateTarget(moveDelta);
		}
	}
}