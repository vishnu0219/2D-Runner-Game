using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsyaclespawner : MonoBehaviour
{
    // Start is called before the first frame update
    public static obsyaclespawner instance;
    public GameObject obstacle;
    public GameObject[] obstacles;
    public bool gameover=false;
    public float mint, maxt;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Spawn()
    {
        float waitTime = 3f;
        while (!gameover)
        {
            SpawnObstacle();
            waitTime = Random.Range(mint, maxt);
            yield return new WaitForSeconds(waitTime);
        }
    }
    void SpawnObstacle()
    {
        int r = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[r], transform.position, Quaternion.identity);
    }
}
