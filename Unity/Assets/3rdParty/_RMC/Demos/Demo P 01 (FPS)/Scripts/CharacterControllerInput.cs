using UnityEngine;
using UnityEngine.InputSystem;

namespace RMC.IntroToUnity.Demos.FPS
{
   //  Namespace Properties ------------------------------
   //  Class Attributes ----------------------------------

   /// <summary>
   /// Take input, move the character
   /// </summary>
   public class CharacterControllerInput : MonoBehaviour
   {
      //  Properties -----------------------------------

      //  Fields ---------------------------------------
      [SerializeField]
      private CharacterController _characterController = null;

      [SerializeField]
      private Rigidbody _rigidBody = null;
      
      private float _speed = 4.0f;
      private float _jumpHeight = 1.0f;

      private Vector3 _velocity;
      private float _gravityY = -9.81f;

      //  Initialization -------------------------------

      //  Unity Methods   ------------------------------
      protected void Update()
      {
         Vector3 move = new Vector3(
            Input.GetAxis("Horizontal"), 
            0,
            Input.GetAxis("Vertical"));

         MoveWithTraditionalInput(move);
      }

      //  Other Methods --------------------------------
      private void MoveWithTraditionalInput(Vector3 move)
      {
         // Move
         _characterController.Move(move * Time.deltaTime * _speed);

         if (move != Vector3.zero)
         {
            gameObject.transform.forward = move;
         }
         else
         {
            _rigidBody.angularVelocity = Vector3.zero;
         }

         // Jump
         if (_characterController.isGrounded && _velocity.y < 0)
         {
            _velocity.y = 0f;
         }

         // Changes the height position of the player..
         if (Input.GetButtonDown("Jump") && _characterController.isGrounded)
         {
            _velocity.y += Mathf.Sqrt(_jumpHeight * -3.0f * _gravityY);
         }

         _velocity.y += _gravityY * Time.deltaTime;
         _characterController.Move(_velocity * Time.deltaTime);
      }

      //  Event Handlers -------------------------------
      public void OnMove(InputAction.CallbackContext context)
      {
         Vector3 moveDelta = context.action.ReadValue<Vector2>();

         //Debug.Log("OnMove() context: " + moveDelta);
      }

      public void OnFire (InputAction.CallbackContext context)
      {
         //Debug.Log("OnFire()");
      }



      /// <summary>
      /// Optional: Call this from a UI Button
      /// </summary>
      public void MoveUp()
      {
         MoveWithTraditionalInput(new Vector3(0, 0, 2));
      }

      /// <summary>
      /// Optional: Call this from a UI Button
      /// </summary>
      public void MoveDown()
      {
         MoveWithTraditionalInput(new Vector3(0, 0, -2));
      }

      /// <summary>
      /// Optional: Call this from a UI Button
      /// </summary>
      public void MoveRight()
      {
         MoveWithTraditionalInput(new Vector3(2, 0, 0));
      }

      /// <summary>
      /// Optional: Call this from a UI Button
      /// </summary>
      public void MoveLeft()
      {
         MoveWithTraditionalInput(new Vector3(-2, 0, 0));
      }
   }
}
