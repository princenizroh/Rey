using Cinemachine;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    public CinemachineVirtualCamera cameras;
    public Collider col;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider Enter: " + other.gameObject.name); // Debug untuk memastikan collider terdeteksi
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered the trigger zone.");
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Collider Exit: " + other.gameObject.name); // Debug untuk memastikan collider terdeteksi
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has exited the trigger zone.");
        }
    }
}
