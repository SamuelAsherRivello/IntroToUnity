using UnityEngine;

namespace RMC.IntroToUnity.Demos.Instantiate
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Hold some custom functionality
	/// </summary>
	public class MyInstance : MonoBehaviour
	{
		//  Properties -----------------------------------

		//  Fields ---------------------------------------
		[SerializeField]
		private Renderer _renderer = null;

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------
		
		//  Other Methods --------------------------------
		public void RandomizeColor()
		{
			float r = Random.Range(0F, 1F);
			float g = Random.Range(0F, 1F);
			float b = Random.Range(0F, 1F);

			Color newColor = new Color(r, g, b);

			_renderer.material.color = newColor;
		}

		//  Event Handlers -------------------------------
	}
}