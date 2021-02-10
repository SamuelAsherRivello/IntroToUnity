using DG.Tweening;
using System;
using UnityEngine;

namespace RMC.IntroToUnity.Demos.Animations
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Play with animation
	/// </summary>
	public class ToonChickPlayer : MonoBehaviour
	{
      //  Properties -----------------------------------

      //  Fields ---------------------------------------
      [SerializeField]
		private Animator _animator = null;

      private const string Walk = "Walk";
      private const string Run = "Run";
      private const string Jump = "Jump";
      private const string Eat = "Eat";

      //  Initialization -------------------------------

      //  Unity Methods   ------------------------------
      protected void Update()
      {
         if (Input.GetKeyDown (KeyCode.LeftArrow))
         {
            ToggleBool(Walk);
         }

         if (Input.GetKeyDown(KeyCode.RightArrow))
         {
            ToggleBool(Run);
         }

         if (Input.GetKeyDown(KeyCode.UpArrow))
         {
            //This is a trigger 
            _animator.SetTrigger(Jump);
         }

         if (Input.GetKeyDown(KeyCode.DownArrow))
         {
            ToggleBool(Eat);
         }
      }

      private void ToggleBool(string name)
      {
         bool isTrue = _animator.GetBool(name);
         _animator.SetBool(name, !isTrue);
      }

      //  Other Methods --------------------------------

      //  Event Handlers -------------------------------
   }
}