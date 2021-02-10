using RMC.Core.Singleton;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RMC.IntroToUnity.Demos.ScenesTimeline
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Load a Scene every x seconds
	/// </summary>
	public class CustomSceneLoader : SingletonMonobehavior<CustomSceneLoader>
	{
      //  Properties -----------------------------------

      //  Fields ---------------------------------------
      [SerializeField]
		private CustomSceneTransition _customSceneTransition = null;

		private const string Scene_01 = "Rocks";
		private const string Scene_02 = "Wood";

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------
		protected void Start()
      {
			_customSceneTransition.OnTransitionStarted.AddListener(
				CustomSceneTransition_OnTransitionStarted);

			_customSceneTransition.OnTransitionMidpointReached.AddListener(
				CustomSceneTransition_OnTransitionMidpointReached);

			_customSceneTransition.OnTransitionCompleted.AddListener(
				CustomSceneTransition_OnTransitionCompleted);

			StartCoroutine(LoadScenes());
      }

      //  Other Methods --------------------------------
      private IEnumerator LoadScenes()
		{

			// 1 Immediately load the scene
			yield return SceneManager.LoadSceneAsync(Scene_01, LoadSceneMode.Additive);
			yield return new WaitForSeconds(2);

			// 2 Fade TO black, pause
			_customSceneTransition.TransitionStart();
			while (!_customSceneTransition.MidpointWasReached)
			{
				yield return new WaitForEndOfFrame();
			}
			_customSceneTransition.TransitionIsPaused = true;

			// 3 Change scenes
			yield return SceneManager.UnloadSceneAsync(Scene_01);
			yield return SceneManager.LoadSceneAsync(Scene_02, LoadSceneMode.Additive);

			// 4 Fade FROM black
			_customSceneTransition.TransitionIsPaused = false;
			
		}

		//  Event Handlers -------------------------------
		private void CustomSceneTransition_OnTransitionStarted()
		{
			// Available if needed
		}

		private void CustomSceneTransition_OnTransitionMidpointReached()
		{
			// Available if needed
		}

		private void CustomSceneTransition_OnTransitionCompleted()
		{
			// Available if needed
		}
	}
}