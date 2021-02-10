using UnityEngine;

namespace RMC.IntroToUnity.Demos.ScriptableObjects
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
		public string FirstName { get { return _firstName; }  }

		//  Fields ---------------------------------------
		private const string FileName = "MySO";
		private const string MenuItem = "Demos/ScriptableObjects/Create New " + FileName;

		[SerializeField]
		private int _age = 0;

		[SerializeField]
		private string _firstName = "";

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------

		//  Other Methods --------------------------------

		//  Event Handlers -------------------------------
	}
}