using UnityEngine;

public class AsteroidsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;
    [SerializeField] private int count = 100;

    [SerializeField] private Vector3 _spawnInterval;
    
    private void Start()
    {
        for (int i = 0; i < count; i++)
        {
            GameObject asteroid = Instantiate(prefabs[Random.Range(0, prefabs.Length - 1)]);
            
            asteroid.transform.position = new Vector3(
                Random.Range(-_spawnInterval.x, _spawnInterval.x),
                Random.Range(-_spawnInterval.y, _spawnInterval.y),
                Random.Range(-_spawnInterval.z, _spawnInterval.z)) + transform.position;
            
            int scale = Random.Range(1, 3);

            asteroid.transform.localScale = new Vector3(
                asteroid.transform.localScale.x,
                asteroid.transform.localScale.y,
                asteroid.transform.localScale.z) * scale;
            
            asteroid.transform.SetParent(transform);
        }
    }
}
