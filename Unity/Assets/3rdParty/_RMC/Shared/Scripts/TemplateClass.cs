using UnityEngine;

namespace RMC.IntroToUnity.Templates
{
	//  Namespace Properties ------------------------------

	//  Class Attributes ----------------------------------

	/// <summary>
	/// Replace with comments...
	/// </summary>
	public class TemplateClass
	{

		//  Events ---------------------------------------

		//  Properties -----------------------------------
		public string SamplePublicText
		{
			get { return _samplePublicText; }
			set { _samplePublicText = value; }
		}

		//  Fields ---------------------------------------
		private string _samplePublicText;

		//  Initialization -------------------------------
		public TemplateClass()
		{
		}

		//  Unity Methods   ------------------------------
		protected void Start()
		{

		}

		//  Other Methods --------------------------------
		public string SamplePublicMethod(string message)
		{
			return message;
		}

		//  Event Handlers -------------------------------
		private void Target_OnEventOccurred(string message)
		{

		}
	}
}