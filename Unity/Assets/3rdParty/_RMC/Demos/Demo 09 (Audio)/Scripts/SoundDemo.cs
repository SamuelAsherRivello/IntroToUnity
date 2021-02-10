using RMC.Projects.Runtime.Managers;
using UnityEngine;

namespace RMC.IntroToUnity.Demos.Audios
{
	//  Namespace Properties ------------------------------
	//  Class Attributes ----------------------------------

	/// <summary>
	/// Play sounds
	/// </summary>
	public class SoundDemo : MonoBehaviour
	{
      //  Properties -----------------------------------

      //  Fields ---------------------------------------

      //  Initialization -------------------------------

      //  Unity Methods   ------------------------------
      protected void Start()
      {
         SoundManager.Instance.PlayAudioClip(SoundConstants.Shoot);
         SoundManager.Instance.PlayAudioClip(SoundConstants.Bounce01);
         SoundManager.Instance.PlayAudioClip(SoundConstants.Click);
      }

      protected void Update ()
      {
         if (Input.GetMouseButtonDown(0))
         {
            SoundManager.Instance.PlayAudioClip(SoundConstants.Shoot);
         }
      }

      //  Other Methods --------------------------------

      //  Event Handlers -------------------------------

   }
}