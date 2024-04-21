using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject spawnee;
    public bool StopSpawning = false;
    public float SpawnTime;
    public float SpawnDelay;
    // Start is called before the first frame update
    // Update is called once per frame
    private void Start()
    {
        InvokeRepeating("SpawnObject", SpawnTime, SpawnDelay);
    }
    public void SpawnObject()
    {
        Instantiate(spawnee, transform.position, Quaternion.Euler(new Vector3(0f, 0f, Random.Range(-25,25))));
        if (StopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
    
}
