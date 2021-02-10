using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace RMC.IntroToUnity.Demos.Events
{
   //  Namespace Properties ------------------------------

   //  Class Attributes ----------------------------------

   // 1. Create the event type
   public class ColorChangeUnityEvent : UnityEvent<Color>
   {
   }

   /// <summary>
   /// Click object with mouse and change the color
   /// </summary>
   public class ClickToChangeColor : MonoBehaviour, IPointerClickHandler
   {
      //  Properties -----------------------------------

      //  Fields ---------------------------------------
      [SerializeField]
      private Renderer _renderer = null;

      //2. Declare the event field
      public ColorChangeUnityEvent OnColorChanged = new ColorChangeUnityEvent();

      //  Initialization -------------------------------

      //  Unity Methods   ------------------------------

      //  Other Methods --------------------------------
      private  void RandomizeColor()
      {
         float r = Random.Range(0F, 1F);
         float g = Random.Range(0F, 1F);
         float b = Random.Range(0F, 1F);

         Color newColor = new Color(r, g, b);

         _renderer.material.color = newColor;
      }

      //  Event Handlers -------------------------------

      /// <summary>
      /// Did user click on me? Requires some setup. Using this...
      /// https://docs.unity3d.com/2019.1/Documentation/ScriptReference/EventSystems.IPointerClickHandler.html
      /// </summary>
      public void OnPointerClick(PointerEventData pointerEventData)
      {
         RandomizeColor();

         if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey(KeyCode.LeftShift))
         {
            //4. Invoke the event
            OnColorChanged.Invoke(_renderer.material.color);
         }
      }
   }
}