using UnityEngine;

public class CrashDtector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("오! 내 머리야!");
        }
    }
}
