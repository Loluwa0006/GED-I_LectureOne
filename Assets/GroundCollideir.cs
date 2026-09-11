using UnityEngine;

public class GroundCollideir : MonoBehaviour
{
    public bool IsGrounded { get; private set; }
    private void OnTriggerEnter(Collider other)
    {
        IsGrounded = true; 
        Debug.Log("Grounded");
    }

    private void OnTriggerExit(Collider other)
    {
        IsGrounded = false;
        Debug.Log("Not Grounded");
    }
}
