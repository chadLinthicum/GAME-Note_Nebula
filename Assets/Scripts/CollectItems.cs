using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public GameObject itemC;
    public GameObject itemCSharp;
    public GameObject itemD;

    private bool itemCFound = false;
    private bool itemCSharpFound = false;
    private bool itemDFound = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "C" && !itemCFound && !itemCSharpFound)
        {
            itemCFound = true;
            Debug.Log("Collected item C");
        }
        else if (other.gameObject.tag == "C")
        {
            ResetCollectedItems();
            Debug.Log("WRONG");
            return;
        }

        if (other.gameObject.tag == "C#" && itemCFound && !itemCSharpFound && !itemDFound)
        {
            itemCSharpFound = true;
            Debug.Log("Collected item C#");
        }
        else if (other.gameObject.tag == "C#")
        {
            ResetCollectedItems();
            Debug.Log("WRONG");
            return;
        }

        if (other.gameObject.tag == "D" && itemCFound && itemCSharpFound && !itemDFound)
        {
            itemDFound = true;
            Debug.Log("Collected item D");
            Debug.Log("NICE PLAYING!");
            ResetCollectedItems();
        }
        else if (other.gameObject.tag == "D")
        {
            ResetCollectedItems();
            Debug.Log("WRONG");
            return;
        }
    }

    private void ResetCollectedItems()
    {
        itemCFound = false;
        itemCSharpFound = false;
        itemDFound = false;
    }
}