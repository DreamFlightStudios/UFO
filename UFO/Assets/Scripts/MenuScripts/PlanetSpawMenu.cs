using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawMenu : MonoBehaviour
{

    public List<GameObject> prefabs = new List<GameObject>(){ };
    public List<Transform> PlanetPos = new List<Transform>() { };
    public int count = 1;
    public int countPrefabs;



    void Start()
    {
        Instantiateprefabs();
        countPrefabs--;
    }

    void Instantiateprefabs()
    {
        for (int i = 0; i < count; i++)
        {
            int _r = Random.Range(0, countPrefabs);
            GameObject Planet = Instantiate(prefabs[_r]);
            prefabs.RemoveAt(_r);

            int r = Random.Range(0, 3);
            Transform PlanetPosition = PlanetPos[r];
            PlanetPos.RemoveAt(r);

            Planet.transform.position = PlanetPosition.transform.position;

            int random = Random.Range(7, 12);
            if (random == 0) random++;
            float x = Planet.transform.localScale.x * random;
            float y = Planet.transform.localScale.y * random;
            float z = Planet.transform.localScale.z * random;
            Vector3 scale = new Vector3(x, y, z);
            Planet.transform.localScale = scale;

            float xrot = Random.Range(0, 360);
            float yrot = Random.Range(0, 360);
            float zrot = Random.Range(0, 360);
            Vector3 rot = new Vector3(xrot, yrot, zrot);
            Planet.transform.rotation = Quaternion.Euler(rot);

            Planet.transform.SetParent(PlanetPosition);
        }
    }
}
