using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCameraScript : MonoBehaviour
{
    public Animator BlackImage;

    public GameObject TTP;
    public GameObject VRImage;
    public GameObject WARNING;

    public GameObject MainCameraVR;
    public GameObject MainCamera;
    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void TTPtrye()
    {
        BlackImage.SetBool("istap", true);
        Invoke("setactive", 2);
    }
    void setactive()
    {
        TTP.SetActive(false);
        WARNING.SetActive(true);
        Invoke("setactive2", 4);
    }
    void setactive2()
    {
        WARNING.SetActive(false);
        VRImage.SetActive(true);
        Invoke("setactive3", 4);
    }
    void setactive3()
    {
        VRImage.SetActive(false);
        Canvas.SetActive(false);
        MainCamera.SetActive(false);
        MainCameraVR.SetActive(true);
    }
}
