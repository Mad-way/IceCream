using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    private bool flag = (true);
    public int thereIs = 0;
    public int myNumber = 3;
    public Text myText;
    public int time = 1;
    public GameObject spawnPoint;
    public GameObject objToSpawn;

    void Update()
    {
        if (flag)
        {
            myText.text = thereIs + "/" + myNumber;
            if (thereIs >= myNumber)
            {
                flag = false;
            }
        }
    }
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(time);
        Vector2 pos = new Vector2(transform.position.x, transform.position.y);
        Instantiate(objToSpawn, spawnPoint.transform.position, Quaternion.identity);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Truff" && Input.GetKey(KeyCode.F))
        {

            thereIs += 1;
            Destroy(col.gameObject);
            if (thereIs == 3)
            {
                StartCoroutine(SpawnCD());
                thereIs *= 0;
            }
        }


    }


}
