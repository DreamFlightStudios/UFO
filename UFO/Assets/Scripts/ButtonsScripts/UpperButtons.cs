using UnityEngine;
using UnityEngine.UI;

public class UpperButtons : MonoBehaviour, IActionCaller
{
    [SerializeField] private Camera CameraR;
    [SerializeField] private Camera CameraL;

    [SerializeField] private Slider UpSlider;
    [SerializeField] private bool _isPlusButton;
    
    public void Call()
    {
        if (_isPlusButton)
            UpSlider.value += 0.1f * Time.fixedDeltaTime;
        else
            UpSlider.value -= 0.1f * Time.fixedDeltaTime;
        RotateCamera();
        
    }
    private void RotateCamera()
    {
        CameraR.transform.localRotation = Quaternion.Euler(0, UpSlider.value * 4, 0);
        CameraL.transform.localRotation = Quaternion.Euler(0, -UpSlider.value * 4, 0);
    }
}
