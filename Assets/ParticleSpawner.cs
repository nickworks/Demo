using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public GameObject prefab;

    /// <summary>
    /// This is how many seconds are left before spawning the next particle.
    /// </summary>
    float countdownToSpawn = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countdownToSpawn -= Time.deltaTime;
        if (countdownToSpawn <= 0) {
            GameObject newObj = Instantiate(prefab, transform.position, Quaternion.identity);
            newObj.GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0, 1, 1, 1, 1, 1);
            countdownToSpawn = Random.Range(0.03f, 0.05f);
            // 0.01666666
        }
    }
}
