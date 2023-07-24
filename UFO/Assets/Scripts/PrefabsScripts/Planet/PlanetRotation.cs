using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationDirection;
    
    private void FixedUpdate() => transform.Rotate(_rotationDirection * Time.fixedDeltaTime);
}
