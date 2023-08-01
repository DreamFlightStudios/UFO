using UnityEngine;

public class AsteroidDestroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) { if (other.gameObject.TryGetComponent(out AsteroidMovement asteroid)) asteroid.Destroy(); }
}
