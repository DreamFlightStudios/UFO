using UnityEngine;

public class PlanetHealth : MonoBehaviour
{
    [SerializeField] private int _live = 10;
    [SerializeField] private GameObject _planet;
    [SerializeField] private GameObject _destroyedPlanet;
    [SerializeField] private GameObject _destroyedPlanetParticalSystem;

    public bool TakeDamage()
    {
        _live--;
        if (_live > 0) return false;

        _planet.SetActive(false);

        Instantiate(_destroyedPlanet, transform.position, Quaternion.identity);
        Instantiate(_destroyedPlanetParticalSystem, transform.position, Quaternion.identity);
        return true;
    }
}