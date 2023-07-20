using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour, IActionCaller
{
    [SerializeField] private Slider _upperSlider, _bottomSlider, _rightAim, _leftAim;
    [SerializeField] private Camera _rightCamera, _leftCamera;
    public void Call()
    {
        _upperSlider.value = PlayerPrefs.GetFloat("CameraRotation");
        _rightCamera.transform.localRotation = Quaternion.Euler(0, _upperSlider.value * 4, 0);
        _leftCamera.transform.localRotation = Quaternion.Euler(0, -_upperSlider.value * 4, 0);

        _bottomSlider.value = PlayerPrefs.GetFloat("BottomSliderPosition");
        _rightAim.value -= _bottomSlider.value;
        _leftAim.value -= _bottomSlider.value;
    }
}
