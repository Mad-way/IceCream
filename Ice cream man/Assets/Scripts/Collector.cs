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
        if (col.tag == "Truff")
        {
            thereIs += 1;
            Destroy(col.gameObject);
        }

    }
}
