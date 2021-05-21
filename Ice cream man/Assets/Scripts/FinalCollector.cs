using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalCollector : MonoBehaviour
{
    private bool flag = (true);
    public int thereIs = 0;
    public int myNumber = 2;
    public Text myText;
    public int time = 6;

    public GameObject final;





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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "IceCreams" && Input.GetKey(KeyCode.F))
        {

            thereIs += 1;
            Destroy(col.gameObject);
            if (thereIs == 2)
            {
                final.SetActive(true);
                thereIs *= 0;
            }
        }


    }


}