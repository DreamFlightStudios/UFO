using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCameraScript : MonoBehaviour
{
    [SerializeField] private Animator BlackImage;

    [SerializeField] private GameObject TTP;
    [SerializeField] private GameObject VRImage;
    [SerializeField] private GameObject WARNING;

    [SerializeField] private GameObject MainCameraVR;
    [SerializeField] private GameObject MainCamera;
    [SerializeField] private GameObject Canvas;
    [SerializeField] private GameObject button;

    public void TTPtrye()
    {
        button.SetActive(false);
        BlackImage.SetBool("istap", true);
        Invoke("setactive", 2);
    }
   private void setactive()
    {
        TTP.SetActive(false);
        WARNING.SetActive(true);
        Invoke("setactive2", 4);
    }
    private void setactive2()
    {
        WARNING.SetActive(false);
        VRImage.SetActive(true);
        Invoke("setactive3", 4);
    }
    private void setactive3()
    {
        VRImage.SetActive(false);
        Canvas.SetActive(false);
        MainCamera.SetActive(false);
        MainCameraVR.SetActive(true);
    }
}
