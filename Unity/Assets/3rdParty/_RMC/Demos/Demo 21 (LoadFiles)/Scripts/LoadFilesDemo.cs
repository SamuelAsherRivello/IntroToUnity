using UnityEngine;

namespace RMC.IntroToUnity.Demos.LoadFiles
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Load a file and log the output
	/// </summary>
	public class LoadFilesDemo : MonoBehaviour
	{
		//  Properties -----------------------------------

		//  Fields ---------------------------------------

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------
		protected void Start()
		{
			LoadFiles();
		}

		protected void Update()
		{
			if (Input.GetMouseButtonDown(0))
         {
				LoadFiles();
			}
		}

		//  Other Methods --------------------------------
		private void LoadFiles ()
		{
			string path = "Assets/3rdParty/_RMC/Demos/Demo 21 (LoadFiles)/Resources/Data.json";
			string contents = System.IO.File.ReadAllText(path);

			Debug.Log("File contents ... \n" + contents);

			JsonWrapper jsonWrapper = JsonUtility.FromJson<JsonWrapper>(contents);

			Debug.Log("Quest list ... ");
			foreach (Quest quest in jsonWrapper.gameData.quests)
			{
				Debug.Log(" Quest: " + quest.name);
			}
		}

		//  Event Handlers -------------------------------
	}
}