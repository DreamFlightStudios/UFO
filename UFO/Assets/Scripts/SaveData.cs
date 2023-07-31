using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    [SerializeField] private Slider _upperSlider,  _bottomSlider; 
    
    private void Start()
    {
        _upperSlider.value = PlayerPrefs.GetFloat("CameraRotation");
        _bottomSlider.value = PlayerPrefs.GetFloat("BottomSliderPosition");
    }

    [ContextMenu("Save Data")]
    public void Save()
    {
        PlayerPrefs.SetFloat("CameraRotation", _upperSlider.value);
        PlayerPrefs.SetFloat("BottomSliderPosition", _bottomSlider.value);
    }
}
