using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector3 : MonoBehaviour
{
    private bool flag = (true);
    public int thereIs = 0;
    public int myNumber = 2;
    public Text myText;

    public GameObject spawnPoint;
    public GameObject objToSpawn;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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
        yield return new WaitForSeconds(3);
        Vector2 pos = new Vector2(transform.position.x, transform.position.y);
        Instantiate(objToSpawn, spawnPoint.transform.position, Quaternion.identity);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "IceCreams" && Input.GetKey(KeyCode.F))
        {

            thereIs += 1;
            Destroy(col.gameObject);
            if (thereIs == 2)
            {
                StartCoroutine(SpawnCD());
                thereIs *= 0;
            }
        }


    }


}
