using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject Wintext;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("enter");
        Instantiate(Wintext);
        Destroy(this);
    }
}
