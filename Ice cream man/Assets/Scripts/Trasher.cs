using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trasher : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag != "Player" && Input.GetKey(KeyCode.F))
        {
            Destroy(col.gameObject);
        }
    }
}
