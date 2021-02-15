using UnityEngine;

namespace RMC.IntroToUnity.Demos.ScriptableObjects.A
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Show off the data type
	/// </summary>
	[CreateAssetMenu(fileName = FileName, menuName = MenuItem, order = 0)]
	public class MySO : ScriptableObject
	{
		//  Properties -----------------------------------
		public int Age {  get { return _age;  }  }
		public string DisplayName { get { return _displayName; }  }

		//  Fields ---------------------------------------
		private const string FileName = "MySO";
		private const string MenuItem = "Intro To Unity Course/Demos/ScriptableObjects/Create New " + FileName;

		[SerializeField]
		private int _age = 0;

		[SerializeField]
		private string _displayName = "";

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------

		//  Other Methods --------------------------------

		//  Event Handlers -------------------------------
	}
}