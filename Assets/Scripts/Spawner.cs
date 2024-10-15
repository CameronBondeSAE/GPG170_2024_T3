using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject prefabToSpawn;
	public Vector3 spawnPosition;
	public Quaternion spawnRotation;
	public float randomSpread = 5f;
	
    // Start is called before the first frame update
    void Start()
    {
	    Spawn();
    }

    public void Spawn()
    {
	    // Spawn a bunch
	    for (int counter = 0; counter < 100; counter++)
	    {
		    spawnPosition.x = Random.Range(0, randomSpread);
		    spawnPosition.z = Random.Range(0, randomSpread);
		    Instantiate(prefabToSpawn, spawnPosition, spawnRotation);
	    }
    }
}
