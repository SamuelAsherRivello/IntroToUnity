using UnityEngine;

namespace RMC.IntroToUnity.Demos.ScriptableObjects.B
{
	//  Namespace Properties ------------------------------


	//  Class Attributes ----------------------------------

	/// <summary>
	/// Show off the data type
	/// </summary>
	[CreateAssetMenu(fileName = FileName, menuName = MenuItem, order = 0)]
	public class IceAbilitySO : BaseAbilitySO
	{
		//  Properties -----------------------------------

		//  Fields ---------------------------------------
		private const string FileName = "IceAbilitySO";
		private const string MenuItem = "Intro To Unity Course/Demos/ScriptableObjects/Create New " + FileName;

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------

		//  Other Methods --------------------------------
		public override void Execute()
		{
			Debug.Log("The Ice Ability will freeze VERY much!");
		}

		//  Event Handlers -------------------------------
	}
}