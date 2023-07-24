using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAsteroid : MonoBehaviour
{
    public List<GameObject> prefabs = new List<GameObject>(){};
    public int count = 1;
    public int complexity = 1;

    public int xcount;
    public int ycount;
    public int zcount;
    private void Start()
    {
        Instantiateprefabs();
    }

    private void Instantiateprefabs()
    {
            for (int i = 0; i < count * complexity; i++)
            {
                GameObject Asteroid = Instantiate(prefabs[Random.Range(0, 10)]);

            float xpos = transform.position.x + Random.Range(-xcount, xcount);
            float ypos = transform.position.y + Random.Range(-ycount, ycount);
            float zpos = transform.position.z + Random.Range(-zcount, zcount);

            Asteroid.transform.position = new Vector3(xpos, ypos, zpos);

                int random = Random.Range(0, 3);
            if (random == 0) random++;
                float x = Asteroid.transform.localScale.x * random;
                float y = Asteroid.transform.localScale.y * random;
                float z = Asteroid.transform.localScale.z * random;
                Vector3 scale = new Vector3(x, y, z);
                Asteroid.transform.localScale = scale;
            Asteroid.transform.SetParent(transform);
        }
    }
}
