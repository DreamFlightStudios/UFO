using UnityEngine;

public class BackMenuButton : MonoBehaviour, IActionCaller
{
    [SerializeField] private GameObject _menuCanvas;
    [SerializeField] private GameObject _settingUpVisionCanvas;
    public void Call()
    {
     _settingUpVisionCanvas.SetActive(false);
        _menuCanvas.SetActive(true);
    }
}
