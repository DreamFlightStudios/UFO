using UnityEngine;

public class FlyAsteroid : MonoBehaviour
{
    [SerializeField] private bool _ufoSaveSolarSystem;
    [SerializeField] private GameObject _particleSystem;

    private PlanetRotation _planetRotation;
    private int _speed;
    private Vector3 _rotationDirection;
    private Rigidbody _rigidbody;
    private bool _isDead;

    private void Start()
    {
        _planetRotation = FindObjectOfType<PlanetRotation>();
        _rigidbody = GetComponent<Rigidbody>();
        _speed = Random.Range(100, 200);
        _rotationDirection = new Vector3(
           Random.Range(-0.2f, 0.2f),
           Random.Range(-0.2f, 0.2f),
           Random.Range(-0.2f, 0.2f));
    }

    private void FixedUpdate()
    {
        if (_isDead == false && _ufoSaveSolarSystem) 
            _rigidbody.velocity = (_planetRotation.gameObject.transform.position - transform.position).normalized * _speed;
        else 
            _rigidbody.velocity = Vector3.zero;
        
        transform.Rotate(_rotationDirection);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out PlanetHealth planet)) _isDead = planet.TakeDamage();
    }

    public void Destroy()
    {
        GameObject boom = Instantiate(_particleSystem, transform.position, transform.rotation);
        Destroy(boom, 0.5f);
	    Destroy(gameObject);
    }
}
