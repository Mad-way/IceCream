using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject objToSpawn;
    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(2);
        Vector2 pos = new Vector2(transform.position.x, transform.position.y);
        Instantiate(objToSpawn, spawnPoint.transform.position, Quaternion.identity);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Truff" || col.tag == "BoxFroze" || col.tag == "IceCreams")
        {
            StartCoroutine(SpawnCD());
        }

    }

}