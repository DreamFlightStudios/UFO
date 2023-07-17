using UnityEngine.UI;
using UnityEngine;

public class RayScript : MonoBehaviour
{
    [SerializeField] private int raylong;
    [SerializeField] private GameObject ps;

    [SerializeField] private Slider UpSlider;
    [SerializeField] private Slider BotSlider;

    [SerializeField] private Camera CameraR;
    [SerializeField] private Camera CameraL;

    [SerializeField] private Slider KnobR;
    [SerializeField] private Slider KnobL;

    [SerializeField] private Image _filledImage;

    private void Start()
    {
        StaticHolder.CameraRot = UpSlider.value * 4;
        CameraR.transform.localRotation = Quaternion.Euler(0, StaticHolder.CameraRot, 0);
        CameraL.transform.localRotation = Quaternion.Euler(0, -StaticHolder.CameraRot, 0);
    }
    private void FixedUpdate()
    {

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * raylong, Color.green);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit, raylong))
        {
            switch (hit.collider.tag)
            {
                case "Asteroid":
                    {
                        GameObject boom = Instantiate(ps, hit.point, Quaternion.identity);
                        Destroy(hit.collider.gameObject);
                        Destroy(boom, 0.5f);
                        break;
                    }
                case "UpperPlus":
                    RotateCamera(UpSlider.value += 0.1f * Time.fixedDeltaTime);
                    break;
                case "UpperMinus":
                    RotateCamera(UpSlider.value -= 0.1f * Time.fixedDeltaTime);
                    break;
                case "BottomPlus":
                    BotSlider.value += 0.1f * Time.fixedDeltaTime;
                    KnobR.value -= 0.1f * Time.fixedDeltaTime;
                    KnobL.value -= 0.1f * Time.fixedDeltaTime;
                    break;
                case "BottomMinus":
                    BotSlider.value -= 0.1f * Time.fixedDeltaTime;
                    KnobR.value += 0.1f * Time.fixedDeltaTime;
                    KnobL.value += 0.1f * Time.fixedDeltaTime;
                    break;
                case "Button":
                    {
                        _filledImage.fillAmount += Time.fixedDeltaTime * 0.5f;
                        if (_filledImage.fillAmount == 1)
                        {
                            hit.collider.gameObject.GetComponent<IActionCaller>().Call();
                        }                      
                        break;
                    }
            }        
        }
        if (hit.collider == null || hit.collider.CompareTag("Button") == false)
        {
            _filledImage.fillAmount -= Time.fixedDeltaTime * 1.5f;
            Debug.Log("уменьшаем");
        }
    }

    private void RotateCamera(float sliderValue)
    {
        StaticHolder.CameraRot = UpSlider.value * 4;
        CameraR.transform.localRotation = Quaternion.Euler(0, StaticHolder.CameraRot, 0);
        CameraL.transform.localRotation = Quaternion.Euler(0, -StaticHolder.CameraRot, 0);
    }
}
