using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{

    public AudioClip C_Key;
    public AudioClip CSharp_Key;
    public AudioClip D_Key;
    public AudioClip DSharp_Key;
    public AudioClip E_Key;
    public AudioClip F_Key;
    public AudioClip FSharp_Key;
    public AudioClip G_Key;
    public AudioClip GSharp_Key;
    public AudioClip A_Key;
    public AudioClip ASharp_Key;
    public AudioClip B_Key;

    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "C")
        {
            //Debug.Log("C");
            playerAudio.PlayOneShot(C_Key, 1.0f);
        }
        if (Col.gameObject.tag == "C#")
        {
            //Debug.Log("C#");
            playerAudio.PlayOneShot(CSharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "D")
        {
            //Debug.Log("D");
            playerAudio.PlayOneShot(D_Key, 1.0f);
        }
        if (Col.gameObject.tag == "D#")
        {
            //Debug.Log("D#");
            playerAudio.PlayOneShot(DSharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "E")
        {
            //Debug.Log("E");
            playerAudio.PlayOneShot(E_Key, 1.0f);
        }
        if (Col.gameObject.tag == "F")
        {
            //Debug.Log("F");
            playerAudio.PlayOneShot(F_Key, 1.0f);
        }
        if (Col.gameObject.tag == "F#")
        {
            //Debug.Log("F#");
            playerAudio.PlayOneShot(FSharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "G")
        {
            //Debug.Log("G");
            playerAudio.PlayOneShot(G_Key, 1.0f);
        }
        if (Col.gameObject.tag == "G#")
        {
            //Debug.Log("G#");
            playerAudio.PlayOneShot(GSharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "A")
        {
            //Debug.Log("A");
            playerAudio.PlayOneShot(A_Key, 1.0f);
        }
        if (Col.gameObject.tag == "A#")
        {
            //Debug.Log("A#");
            playerAudio.PlayOneShot(ASharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "B")
        {
            //Debug.Log("B");
            playerAudio.PlayOneShot(B_Key, 1.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
