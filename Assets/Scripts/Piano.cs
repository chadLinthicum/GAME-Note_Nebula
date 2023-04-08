using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    public int coins;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "C")
        {
            Debug.Log("C");
        }
        if (Col.gameObject.tag == "C#")
        {
            Debug.Log("C#");
        }
        if (Col.gameObject.tag == "D")
        {
            Debug.Log("D");
        }
        if (Col.gameObject.tag == "D#")
        {
            Debug.Log("D#");
        }
        if (Col.gameObject.tag == "E")
        {
            Debug.Log("E");
        }
        if (Col.gameObject.tag == "F")
        {
            Debug.Log("F");
        }
        if (Col.gameObject.tag == "F#")
        {
            Debug.Log("F#");
        }
        if (Col.gameObject.tag == "G")
        {
            Debug.Log("G");
        }
        if (Col.gameObject.tag == "G#")
        {
            Debug.Log("G#");
        }
        if (Col.gameObject.tag == "A")
        {
            Debug.Log("A");
        }
        if (Col.gameObject.tag == "A#")
        {
            Debug.Log("A#");
        }
        if (Col.gameObject.tag == "B")
        {
            Debug.Log("B");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
