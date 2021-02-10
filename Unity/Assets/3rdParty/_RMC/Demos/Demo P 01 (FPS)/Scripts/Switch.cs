using UnityEngine;

namespace RMC.IntroToUnity.Demos.FPS
{
   //  Namespace Properties ------------------------------
   //  Class Attributes ----------------------------------

   /// <summary>
   /// Detect player, change color
   /// </summary>
   public class Switch : MonoBehaviour
   {
      //  Properties -----------------------------------

      //  Fields ---------------------------------------
      [SerializeField]
      private Renderer _renderer = null;

      [SerializeField]
      private Color _offColor = Color.white;

      [SerializeField]
      private Color _onColor = Color.green;

      //  Initialization -------------------------------

      //  Unity Methods   ------------------------------
      protected void Awake ()
      {
         _renderer.material.color = _offColor;
      }

      //  Other Methods --------------------------------

      //  Event Handlers -------------------------------
      private void OnTriggerEnter(Collider other)
      {
         _renderer.material.color = _onColor;
      }

      private void OnTriggerExit(Collider other)
      {
         _renderer.material.color = _offColor;
      }
   }
}
