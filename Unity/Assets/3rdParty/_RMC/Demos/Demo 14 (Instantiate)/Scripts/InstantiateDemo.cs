using System;
using UnityEngine;

namespace RMC.IntroToUnity.Demos.Instantiate
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Create and destroy GameObjects
	/// </summary>
	public class InstantiateDemo : MonoBehaviour
	{
		//  Properties -----------------------------------

		//  Fields ---------------------------------------
		[SerializeField]
		private GameObject _source = null;

		private GameObject _instance = null;

      //  Initialization -------------------------------

      //  Unity Methods   ------------------------------
      protected void Start()
      {
			CreateInstance();
		}

		protected void Update()
		{
			if (Input.GetMouseButtonDown(0))
         {
				CreateInstance();
			}
		}

		//  Other Methods --------------------------------
		private void CreateInstance()
		{
			// Destroy one
			if (_instance != null)
         {
				Destroy(_instance);
         }

			// Create one
			_instance = Instantiate<GameObject>(_source);

			float x = UnityEngine.Random.Range(-3, 3);
			float y = UnityEngine.Random.Range(1, 5);
			float z = UnityEngine.Random.Range(-3, 3);

	
			// Set position and rotation
			_instance.transform.rotation = Quaternion.identity;
			_instance.transform.position = new Vector3(x, y, z);

			// Call strong typed method on custom component
			Rigidbody rigidbody = _instance.gameObject.GetComponent<Rigidbody>();
			rigidbody.AddForce(new Vector3(11, 100, 33));

			// Call strong typed method on custom component
			MyInstance myInstance = _instance.gameObject.GetComponent<MyInstance>();
			myInstance.RandomizeColor();

		}

		//  Event Handlers -------------------------------
	}
}