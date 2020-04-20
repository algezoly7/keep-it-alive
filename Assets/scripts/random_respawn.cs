using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_respawn : MonoBehaviour
{

    public GameObject meteor;
    public Vector3 spawnvalue;
    public float startSpawnWait;
    public float minSpawnWait;
    public float maxSpawnWait;
    public float spawnWait;
    public bool stop;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(minSpawnWait, maxSpawnWait);
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(startSpawnWait);
        while (!stop)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnvalue.x, spawnvalue.x), 1, Random.Range(-spawnvalue.z, spawnvalue.z));
            Instantiate(meteor, spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
