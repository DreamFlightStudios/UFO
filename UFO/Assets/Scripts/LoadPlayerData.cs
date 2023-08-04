using UnityEngine;
using UnityEngine.UI;

public class LoadPlayerData : MonoBehaviour
{
    [SerializeField] private Slider _rightAim,  _leftAim;
    [SerializeField] private Camera _rightCamera, _leftCamera;

    private void Start()
    {
        float cameraValue = PlayerPrefs.GetFloat("CameraRotation");
        _rightCamera.transform.localRotation = Quaternion.Euler(0, cameraValue * 4, 0);
        _leftCamera.transform.localRotation = Quaternion.Euler(0, -cameraValue * 4, 0);

        float aimValue = PlayerPrefs.GetFloat("BottomSliderPosition");
        _rightAim.value -= aimValue;
        _leftAim.value -= aimValue;
    }
}
