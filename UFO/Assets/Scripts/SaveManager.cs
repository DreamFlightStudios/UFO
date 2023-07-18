using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    [SerializeField] private float RotCamera; 

    [SerializeField] private Slider UpperSlider; 
    [SerializeField] private Slider BottomSlider; 

    [SerializeField] private Slider SliderR; 
    [SerializeField] private Slider SliderL; 

    [SerializeField] private Camera CameraR;
    [SerializeField] private Camera CameraL;

    private void Start()
    {
        CameraR.transform.localRotation = Quaternion.Euler(0, RotCamera, 0);
        CameraL.transform.localRotation = Quaternion.Euler(0, -RotCamera, 0);

        SliderR.value -= BottomSlider.value;
        SliderL.value -= BottomSlider.value;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
