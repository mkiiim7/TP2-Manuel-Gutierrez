using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Obstaculos : MonoBehaviour
{
    [SerializeField] GameObject[] obstaculosPrefab;
    [SerializeField] float seconds_toSpawn = 3.0f;
    [SerializeField] float minTrasx;
    [SerializeField] float maxTrasx;
    [SerializeField] float minTrasy;
    [SerializeField] float maxTrasy;
    void Start()
    {
        StartCoroutine(ObstaculosSpawn());
    }

    IEnumerator ObstaculosSpawn()
    {
        while (true) 
        {
            var wantedx = Random.Range(minTrasx, maxTrasx);
            var wantedy = Random.Range(minTrasy, maxTrasy);
            var position = new Vector3(wantedx, wantedy);
            GameObject gameObject = Instantiate(obstaculosPrefab[Random.Range(0, obstaculosPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(seconds_toSpawn);
            Destroy(gameObject, 5f);
        }
    }
    void Update()
    {
        
    }
}
