using UnityEngine;

public class WinArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You win!");
    }
}
