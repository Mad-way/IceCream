using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isecreamhold : MonoBehaviour
{
    public bool hold;
    public float distance;
    public Transform holdPoint;
    public float throwObj;
    public GameObject iceCream;


    void Start()
    {

    }

    void Update()
    {
        if (hold && iceCream != null)
        {
            iceCream.transform.position = holdPoint.transform.position;
        }
        else if (!hold && iceCream != null)
        {
            iceCream.transform.position = iceCream.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.E) && iceCream != null)
        {
            if (!hold && Vector2.Distance(holdPoint.transform.position, iceCream.transform.position) < distance && iceCream.CompareTag("Truff"))
            {
                hold = true;
            }
            else if (hold)
            {
                hold = false;
            }

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