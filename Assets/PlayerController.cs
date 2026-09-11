using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] PlayerInput playerInput;


    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpPower = 20.0f;
    [SerializeField] Camera cam;

    [SerializeField] GroundCollideir groundCollideir;



    void FixedUpdate()
    {
        var lateralSpeed = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y);
       
            float leftRight = playerInput.actions["Right"].ReadValue<float>() - playerInput.actions["Left"].ReadValue<float>();
            float forwardBack = playerInput.actions["Up"].ReadValue<float>() - playerInput.actions["Down"].ReadValue<float>();

            var movement = leftRight * cam.transform.right + forwardBack * transform.forward;
        if (lateralSpeed.magnitude >= moveSpeed)
        {
            var speedNormalized = lateralSpeed.normalized;
            var extraSpeed = Vector2.Dot(new Vector2(movement.x, movement.z), speedNormalized);
            if (extraSpeed > 0)
            {
                movement -= extraSpeed * new Vector3(speedNormalized.x, 0, speedNormalized.y);
            }
        }

        rb.AddForce(movement, ForceMode.VelocityChange);


       

    }

    private void Update()
    {
        if (playerInput.actions["Jump"].WasPerformedThisFrame() && groundCollideir.IsGrounded)
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.VelocityChange);
        }
    }


}
