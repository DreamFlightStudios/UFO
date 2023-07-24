using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTestSceneButton : MonoBehaviour, IActionCaller
{
    public void Call()
    {
  SceneManager.LoadScene(1);
    }
}
