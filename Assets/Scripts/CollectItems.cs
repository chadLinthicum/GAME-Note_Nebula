using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    private bool itemCFound = false;
    private bool itemDSharpFound = false;
    private bool itemFFound = false;

    public AudioClip WIN;

    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "C" && !itemCFound && !itemDSharpFound)
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

        if (other.gameObject.tag == "D#" && itemCFound && !itemDSharpFound && !itemFFound)
        {
            itemDSharpFound = true;
            Debug.Log("Collected item D#");
        }
        else if (other.gameObject.tag == "D#")
        {
            ResetCollectedItems();
            Debug.Log("WRONG");
            return;
        }

        if (other.gameObject.tag == "F" && itemCFound && itemDSharpFound && !itemFFound)
        {
            itemFFound = true;
            Debug.Log("Collected item F");
            playerAudio.PlayOneShot(WIN, 0.5f);
            ResetCollectedItems();
        }
        else if (other.gameObject.tag == "F")
        {
            ResetCollectedItems();
            Debug.Log("WRONG");
            return;
        }
    }

    private void ResetCollectedItems()
    {
        itemCFound = false;
        itemDSharpFound = false;
        itemFFound = false;
    }
}