using System;
using UnityEngine;

public class PlanetHealth : MonoBehaviour
{
    [SerializeField] private int _live = 10;
    [SerializeField] private GameObject _planet;
    [SerializeField] private GameObject _destroyedPlanet;
    [SerializeField] private GameObject _destroyedPlanetParticleSystem;

    public void TakeDamage()
    {
        _live--;
        if (_live > 0) return;

        _planet.SetActive(false);

        Instantiate(_destroyedPlanet, transform.position, Quaternion.identity);
        Instantiate(_destroyedPlanetParticleSystem, transform.position, Quaternion.identity);
    }
}