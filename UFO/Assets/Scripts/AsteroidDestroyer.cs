using UnityEngine;

public class AsteroidDestroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) { if (other.gameObject.TryGetComponent(out FlyAsteroid asteroid)) asteroid.Destroy(); }
}
