using UnityEngine;
using UnityEngine.UI;

public class DataService : MonoBehaviour
{
    [SerializeField] private Slider _upperSlider,  _bottomSlider,  _rightAim,  _leftAim; 

    [SerializeField] private Camera _rightCamera, _leftCamera;

    private void Start()
    {
        _upperSlider.value = PlayerPrefs.GetFloat("CameraRotation");
        _rightCamera.transform.localRotation = Quaternion.Euler(0, _upperSlider.value * 4, 0);
        _leftCamera.transform.localRotation = Quaternion.Euler(0, -_upperSlider.value * 4, 0);

        _bottomSlider.value = PlayerPrefs.GetFloat("AimPosition");
        _rightAim.value -= _bottomSlider.value;
        _leftAim.value -= _bottomSlider.value;
    }

    [ContextMenu("SaveData")]
    public void SaveData()
    {
        PlayerPrefs.SetFloat("CameraRotation", _upperSlider.value);
        PlayerPrefs.SetFloat("AimPosition", _bottomSlider.value);
    }
}
