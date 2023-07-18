using UnityEngine;

public class QuitButton : MonoBehaviour, IActionCaller
{
    public void Call()
    {
        Application.Quit();
    }
}
