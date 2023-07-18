using UnityEngine;

public class SwitchCanvasButton : MonoBehaviour, IActionCaller
{
    [SerializeField] private GameObject _includedCanvas, _switchableCanvas;
    
    public void Call()
    {
        _includedCanvas.SetActive(true);
        _switchableCanvas.SetActive(false);
    }
}
