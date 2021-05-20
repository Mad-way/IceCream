using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Isecreamhold : MonoBehaviour
{
    public float distance;
    public Transform holdPoint;
    public GameObject iceCream;
    public GameObject myIceCream;




    void Start()
    {
        myIceCream = null;
        iceCream = null;

    }

    void Update()
    {
        if (myIceCream != null)
        {
            myIceCream.transform.position = holdPoint.transform.position;
            if (Input.GetKey(KeyCode.F))
            {
                Instantiate(myIceCream, transform.position, Quaternion.identity);
                Destroy(myIceCream);
                myIceCream = null;

            }
        }
        if (myIceCream == null && iceCream != null && Input.GetKey(KeyCode.E))
        {
            myIceCream = iceCream;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Truff")) iceCream = other.gameObject;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Truff")) iceCream = null;
    }

}