using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    [SerializeField] private bool _ufoSaveSolarSystem;
    [SerializeField] private GameObject _particleSystem;
    [SerializeField] private float _coefficientMotionDeviation = 100;

    private PlanetHealth _planetHealth;
    private int _speed;
    private Vector3 _rotationDirection;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _planetHealth = FindObjectOfType<PlanetHealth>();
        _rigidbody = GetComponent<Rigidbody>();
        
        _planetHealth.OnDied += ChangeVelocity;

        _speed = Random.Range(100, 200);
        _rotationDirection = new Vector3(
           Random.Range(-0.2f, 0.2f),
           Random.Range(-0.2f, 0.2f),
           Random.Range(-0.2f, 0.2f));
        
        _rigidbody.velocity = _ufoSaveSolarSystem
            ? (_planetHealth.gameObject.transform.position - transform.position).normalized * _speed
            : Vector3.zero;
    }

    private void ChangeVelocity()
    {
        print("A");
        _rigidbody.velocity = new Vector3(
            Random.Range(-_coefficientMotionDeviation, _coefficientMotionDeviation),
            Random.Range(-_coefficientMotionDeviation, _coefficientMotionDeviation),
            Random.Range(-_coefficientMotionDeviation, _coefficientMotionDeviation));
    }

    private void FixedUpdate() => transform.Rotate(_rotationDirection);

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out PlanetHealth planet)) planet.TakeDamage();
    }

    public void Destroy()
    {
        GameObject boom = Instantiate(_particleSystem, transform.position, transform.rotation);
        Destroy(boom, 0.5f);
        _planetHealth.OnDied -= ChangeVelocity;
	    Destroy(gameObject);
    }
}
