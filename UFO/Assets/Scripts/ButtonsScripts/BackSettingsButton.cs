using UnityEngine;

public class BackSettingsButton : MonoBehaviour, IActionCaller
{
    [SerializeField] private GameObject _menuCanvas;
    [SerializeField] private GameObject _settingUpVisionCanvas;
    public void Call()
    {
        _settingUpVisionCanvas.SetActive(true);
        _menuCanvas.SetActive(false);
    }
}
