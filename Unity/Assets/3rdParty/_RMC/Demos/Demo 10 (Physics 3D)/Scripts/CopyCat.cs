using UnityEngine;

namespace RMC.IntroToUnity.Demos.Physics3D
{
   //  Namespace Properties ------------------------------

   //  Class Attributes ----------------------------------

   /// <summary>
   /// Observe other event to change color
   /// </summary>
   public class CopyCat : MonoBehaviour
   {
      //  Properties -----------------------------------

      //  Fields ---------------------------------------
      [SerializeField]
      private Renderer _renderer = null;

      [SerializeField]
      private float _raycastMaxDistance = 3;

      private RaycastHit raycastHit;
      private Ray ray;
      private float duration = 0.1f;
      private Vector3 _raycastDirection = Vector3.down;

      //  Initialization -------------------------------

      //  Unity Methods   ------------------------------
      protected void Update()
      {
         ray = new Ray(transform.position, _raycastDirection);

         if (Physics.Raycast (ray, out raycastHit, _raycastMaxDistance))
         {
            RayCast_OnHit(raycastHit.collider.gameObject);
         }

         Vector3 end = ray.origin + (_raycastDirection * _raycastMaxDistance);
         Debug.DrawLine(ray.origin, end, Color.white, duration);
      }

      //  Other Methods --------------------------------

      //  Event Handlers -------------------------------
      private void RayCast_OnHit(GameObject go)
      {
         Flat flat = go.GetComponent<Flat>();
         if (flat != null)
         {
            _renderer.material.color = flat.Color;
         }
      }
   }
}