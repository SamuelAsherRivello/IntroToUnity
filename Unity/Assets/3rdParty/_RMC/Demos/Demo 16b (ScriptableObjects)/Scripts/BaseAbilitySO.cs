using UnityEngine;

namespace RMC.IntroToUnity.Demos.ScriptableObjects.B
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Show off the data type
	/// </summary>
	public class BaseAbilitySO : ScriptableObject
	{
		//  Properties -----------------------------------
		public virtual int Damage {  get { return _damage;  }  }
		public virtual string DisplayName { get { return _displayName; }  }

		//  Fields ---------------------------------------

		[SerializeField]
		private int _damage = 0;

		[SerializeField]
		private string _displayName = "";

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------

		//  Other Methods --------------------------------
		public virtual void Execute()
		{
			// Override method to do something...
		}

		//  Event Handlers -------------------------------
	}
}