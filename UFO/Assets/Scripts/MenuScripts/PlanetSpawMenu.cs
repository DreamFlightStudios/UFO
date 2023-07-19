using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawMenu : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefabs = new List<GameObject>();
    [SerializeField] private List<Transform> PlanetPos = new List<Transform>();
    [SerializeField] private int count = 1;
    
    private void Start()
    {
        for (int i = 0; i < count; i++)
        {
            int randomPosition = Random.Range(0, 3);
            Transform position = PlanetPos[randomPosition];
            PlanetPos.RemoveAt(randomPosition);
            
            int randomPlanet = Random.Range(0, prefabs.Count);
            GameObject planet = Instantiate(prefabs[randomPlanet], position);
            prefabs.RemoveAt(randomPlanet);

            planet.transform.position = position.transform.position;

            planet.transform.localScale = new Vector3(planet.transform.localScale.x, planet.transform.localScale.y, planet.transform.localScale.z) * Random.Range(1, 10);
            
            planet.transform.rotation = Quaternion.Euler(new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
        }
    }
}
