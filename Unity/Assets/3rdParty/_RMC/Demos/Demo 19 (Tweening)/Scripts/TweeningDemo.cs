using DG.Tweening;
using System;
using UnityEngine;

namespace RMC.IntroToUnity.Demos.Tweenings
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Play with tweening
	/// </summary>
	public class TweeningDemo : MonoBehaviour
	{
		//  Properties -----------------------------------

		//  Fields ---------------------------------------
		[SerializeField]
		private Transform _target = null;

      //  Initialization -------------------------------

      //  Unity Methods   ------------------------------
      protected void Start()
		{
			SetupEasy();
			SetupComplex();
		}

		//  Other Methods --------------------------------
		private void SetupEasy()
		{
			float duration = 1;
			_target.DORotate(new Vector3(0, 45, 0), duration);
		}

		private void SetupComplex()
		{
			// Helpful guide (Not directly related to DOTween)
			// https://easings.net/

			// Create
			float duration = 1;
			Sequence mySequence = DOTween.Sequence();

			// Populate
			mySequence.Append(_target
				.DOScale(new Vector3(2, 2, 2), duration)
				.SetEase(Ease.InSine));

			mySequence.Append(_target
					.DOScale(new Vector3(1, 1, 1), duration)
					.SetEase(Ease.OutSine));

			// Start
			mySequence
				.SetLoops(-1)
				.OnComplete(Sequence_OnComplete)
				.OnStepComplete(Sequence_OnStepComplete)
				.Play();
		}
		//  Event Handlers -------------------------------
		private void Sequence_OnStepComplete()
      {
			//Debug.Log("Sequence_OnStepComplete! ");
      }

		private void Sequence_OnComplete()
		{
			//Not called when infinite loops
			//Debug.Log("Sequence_OnComplete! ");
		}

	}
}