using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public static int coinCount = -1;
    [SerializeField] TMP_Text coinTracker;
    private void OnTriggerEnter(Collider other)
    {
        coinCount++;
        coinTracker.text = coinCount.ToString();
        gameObject.SetActive(false);
    }
}
