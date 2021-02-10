using UnityEngine;

namespace RMC.IntroToUnity.Demos.Events
{
   //  Namespace Properties ------------------------------

   //  Class Attributes ----------------------------------

   /// <summary>
   /// Observe other event to change color
   /// </summary>
   public class ObserveToChangeColor : MonoBehaviour
   {
      //  Properties -----------------------------------

      //  Fields ---------------------------------------
      [SerializeField]
      private ClickToChangeColor _clickToChangeColor = null;

      [SerializeField]
      private Renderer _renderer = null;

      //  Initialization -------------------------------

      //  Unity Methods   ------------------------------
      protected void Awake()
      {
         //3. Observe the event
         _clickToChangeColor.OnColorChanged.AddListener(ClickToChangeColor_OnColorChanged);
      }
      //  Other Methods --------------------------------

      //  Event Handlers -------------------------------
      public void ClickToChangeColor_OnColorChanged(Color color)
      {
         _renderer.material.color = color;
      }
   }
}