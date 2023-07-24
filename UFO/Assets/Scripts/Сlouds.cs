using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Сlouds : MonoBehaviour
{
    public GameObject cloudPrefab;
    public GameObject empty;

    void Start()
    {
        InvokeRepeating("cloudsLive", 0f, 8f);
    }

    void Update()
    {
        empty.transform.Rotate(4 * Time.deltaTime, 8 * Time.deltaTime, 4 * Time.deltaTime);
    }

    private void cloudsLive()
    {
        for(int i = 0; i < 5; i++)
        {
            float xpos = empty.transform.position.x;
            float ypos = empty.transform.position.y;
            float zpos = empty.transform.position.z;

            int boolCount = Random.Range(0, 3);
            if (boolCount == 1)
            {
                xpos += 36 * transform.localScale.x;
                ypos += Random.Range(-6, 6);
                zpos += Random.Range(-6, 6);
            }
            else if (boolCount == 2)
            {
                ypos += 36 * transform.localScale.y;
                xpos += Random.Range(-6, 6);
                zpos += Random.Range(-6, 6);
            }
            else
            {
                zpos += 36 * transform.localScale.z;
                ypos += Random.Range(-6, 6);
                xpos += Random.Range(-6, 6);
            }
            Vector3 cloudpos = new Vector3(xpos, ypos, zpos);
            GameObject cloud = Instantiate(cloudPrefab, cloudpos, Quaternion.identity);

            int scale = Random.Range(40, 80);
            float xScale = transform.localScale.x * scale;
            float yScale = transform.localScale.y * scale;
            float zScale = transform.localScale.z * scale;
            Vector3 cloudScale = new Vector3(xScale, yScale, zScale);
            cloud.transform.localScale = cloudScale;

            cloud.transform.SetParent(empty.transform);
                Destroy(cloud, 50);
            }
        }
    }
