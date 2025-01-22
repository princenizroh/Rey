using UnityEngine;
using Cinemachine;

[System.Serializable]
public class CameraTriggerElement
{
    public CinemachineVirtualCamera camera;
    public Collider col;
}

public class CameraManager : MonoBehaviour
{
    public CameraTriggerElement[] cameras;
    public CinemachineVirtualCamera startCamera;
    private CinemachineVirtualCamera _currentCam;

    private void Start()
    {
        _currentCam = startCamera;
        if (_currentCam != null)
        {
            _currentCam.Priority = 20;
        }
    }

    public void SwitchCamera(CinemachineVirtualCamera newCam)
    {
        if (_currentCam != null)
        {
            _currentCam.Priority = 10;
        }

        _currentCam = newCam;
        if (_currentCam != null)
        {
            _currentCam.Priority = 20;
        }
    }
}
