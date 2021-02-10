using UnityEngine;

namespace RMC.IntroToUnity.Demos.Physics3D
{
   //  Namespace Properties ------------------------------

   //  Class Attributes ----------------------------------

   /// <summary>
   /// Hold a color
   /// </summary>
   public class Flat : MonoBehaviour
   {
      //  Properties -----------------------------------
      public Color Color {  get { return _renderer.material.color; } }

      //  Fields ---------------------------------------
      [SerializeField]
      private Renderer _renderer = null;

      //  Initialization -------------------------------

      //  Unity Methods   ------------------------------

      //  Other Methods --------------------------------

      //  Event Handlers -------------------------------
   }
}