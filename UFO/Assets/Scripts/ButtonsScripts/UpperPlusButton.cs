using UnityEngine;
using UnityEngine.UI;

public class UpperPlusButton : MonoBehaviour, IActionCaller
{
    [SerializeField] private Camera CameraR;
    [SerializeField] private Camera CameraL;

    [SerializeField] private Slider UpSlider;
    public void Call()
    {
        RotateCamera(UpSlider.value += 0.1f * Time.fixedDeltaTime);
    }
    private void RotateCamera(float sliderValue)
    {
        StaticHolder.CameraRot = UpSlider.value * 4;
        CameraR.transform.localRotation = Quaternion.Euler(0, StaticHolder.CameraRot, 0);
        CameraL.transform.localRotation = Quaternion.Euler(0, -StaticHolder.CameraRot, 0);
    }
}
