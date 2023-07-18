using UnityEngine.UI;
using UnityEngine;

public class RayScript : MonoBehaviour
{
    [SerializeField] private int raylong;
    [SerializeField] private GameObject ps;

    [SerializeField] private Image _filledImageL;
    [SerializeField] private Image _filledImageR;
    
    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * raylong, Color.green);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit, raylong))
        {
            switch (hit.collider.tag)
            {
                case "Object":
                    {
                        _filledImageL.fillAmount += Time.fixedDeltaTime * 0.5f;
                        _filledImageR.fillAmount += Time.fixedDeltaTime * 0.5f;
                        if (_filledImageL.fillAmount == 1)
                        {
                            hit.collider.gameObject.GetComponent<IActionCaller>().Call();
                        }
                        break;
                    }
                case "Asteroid":
                    {
                        GameObject boom = Instantiate(ps, hit.point, Quaternion.identity);
                        Destroy(hit.collider.gameObject);
                        Destroy(boom, 0.5f);
                        break;
                    }
            }        
        }
        if (hit.collider == null || hit.collider.CompareTag("Object") == false)
        {
            _filledImageL.fillAmount -= Time.fixedDeltaTime * 2f;
            _filledImageR.fillAmount -= Time.fixedDeltaTime * 2f;
        }
    }
}
