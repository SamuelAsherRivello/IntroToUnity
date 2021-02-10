using UnityEngine;

namespace RMC.IntroToUnity.Demos.FPS
{
   //  Namespace Properties ------------------------------
   //  Class Attributes ----------------------------------

   /// <summary>
   /// Follow the target
   /// </summary>
   public class MapCamera : MonoBehaviour
   {
      //  Properties -----------------------------------

      //  Fields ---------------------------------------
      [SerializeField]
      private Transform _target = null;

      //  Initialization -------------------------------

      //  Unity Methods   ------------------------------
      protected void FixedUpdate ()
      {
         Vector3 newPosition = new Vector3(
            _target.transform.position.x, 
            _target.transform.position.y, 
            transform.position.z);

         transform.position = newPosition;
      }

      //  Other Methods --------------------------------

      //  Event Handlers -------------------------------
   }
}
