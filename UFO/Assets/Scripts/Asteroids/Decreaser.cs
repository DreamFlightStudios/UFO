using UnityEngine;

public class Decreaser : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleRatio;
    
    private void OnTriggerStay(Collider other) => transform.localScale -= _scaleRatio;
}
