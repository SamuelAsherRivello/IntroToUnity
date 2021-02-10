using UnityEngine;

namespace RMC.IntroToUnity.Demos.Inputs
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Input with traditional system.
	/// </summary>
	public class InputDemoTraditional : MonoBehaviour
	{
		//  Properties -----------------------------------

		//  Fields ---------------------------------------
		[SerializeField]
		private Transform _target = null;

		[SerializeField]
		private float _sensitivity = 1f;

		private Vector3 _lastMousePosition = Vector3.zero;

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------
		protected void Update ()
      {
			if (Input.GetMouseButton(0))
         {
				float x = Input.mousePosition.y - _lastMousePosition.y;
				float y = -(Input.mousePosition.x - _lastMousePosition.x);
				float z = 0;

				Vector3 mousePositionDelta = _sensitivity * new Vector3(x, y, z);
				RotateTarget(mousePositionDelta);
			}

			_lastMousePosition = Input.mousePosition;

		}

		//  Other Methods --------------------------------
		private void RotateTarget(Vector3 delta)
		{
			_target.Rotate(delta, Space.World);
		}

		//  Event Handlers -------------------------------
	}
}