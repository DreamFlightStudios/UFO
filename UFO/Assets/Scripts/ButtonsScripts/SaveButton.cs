using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveButton : MonoBehaviour, IActionCaller
{
   public void Call()
    {
        SceneManager.LoadScene(0);
    }
}
