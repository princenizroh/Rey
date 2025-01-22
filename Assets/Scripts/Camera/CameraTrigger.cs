using UnityEngine;
using Cinemachine;

public class CameraTrigger : MonoBehaviour
{
    public CinemachineVirtualCamera targetCamera; 
    private CameraManager cameraManager; 

    private void Start()
    {
        cameraManager = FindObjectOfType<CameraManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (cameraManager != null && targetCamera != null)
            {
                cameraManager.SwitchCamera(targetCamera);
            }
        }
    }
}
