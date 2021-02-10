using RMC.Core.Singleton;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace RMC.IntroToUnity.Demos.ScenesTimeline
{
	//  Namespace Properties ------------------------------

	//  Class Attributes ----------------------------------

	/// <summary>
	/// Fade to/from black for a transition between scenes
	/// </summary>
	public class CustomSceneTransition : SingletonMonobehavior<CustomSceneTransition>
	{
		//  Properties -----------------------------------
		public bool MidpointWasReached 
		{  
			get 
			{ 
				return _midpointWasReached;
			} 

			private set 
			{ 
				_midpointWasReached = value;
			} 
		}

		public bool TransitionIsPaused { 
			get 
			{
				return _transitionIsPaused;
			} 
			set 
			{
				_transitionIsPaused = value;

				if (_transitionIsPaused)
            {
					_playableDirector.Pause();

				}
				else
            {
					_playableDirector.Play();
				}
			} 
		}


		//  Fields ---------------------------------------
		[SerializeField]
		public PlayableDirector _playableDirector = null;

		[HideInInspector]
		public UnityEvent OnTransitionStarted = new UnityEvent();

		[HideInInspector]
		public UnityEvent OnTransitionMidpointReached = new UnityEvent();

		[HideInInspector]
		public UnityEvent OnTransitionCompleted = new UnityEvent();

		private bool _transitionIsPaused = false;
		private bool _midpointWasReached = false;

		//  Initialization -------------------------------

		//  Unity Methods   ------------------------------

      //  Other Methods --------------------------------
      public void TransitionStart ()
      {
			OnTransitionStarted.Invoke();

			_playableDirector.time = 0;

			TransitionIsPaused = false;
			MidpointWasReached = false;

			//TODO: Fix timing
			//Create new signal, observe locally, and dispatch this event properly
			OnTransitionCompleted.Invoke();
      }

		//  Event Handlers -------------------------------
		public void Signal_OnTransitionMidpointReached()
      {
			MidpointWasReached = true;
			
			OnTransitionMidpointReached.Invoke();
		}
	}
}