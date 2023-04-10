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
    public AudioClip Piano_SmokeOnTheWater;

    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider Col)
    {
        //Test Piano
        if (Col.gameObject.tag == "C")
        {
            playerAudio.PlayOneShot(C_Key, 1.0f);
        }
        if (Col.gameObject.tag == "C#")
        {
            playerAudio.PlayOneShot(CSharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "D")
        {
            playerAudio.PlayOneShot(D_Key, 1.0f);
        }
        if (Col.gameObject.tag == "D#")
        {
            playerAudio.PlayOneShot(DSharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "E")
        {
            playerAudio.PlayOneShot(E_Key, 1.0f);
        }
        if (Col.gameObject.tag == "F")
        {
            playerAudio.PlayOneShot(F_Key, 1.0f);
        }
        if (Col.gameObject.tag == "F#")
        {
            playerAudio.PlayOneShot(FSharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "G")
        {
            playerAudio.PlayOneShot(G_Key, 1.0f);
        }
        if (Col.gameObject.tag == "G#")
        {
            playerAudio.PlayOneShot(GSharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "A")
        {
            playerAudio.PlayOneShot(A_Key, 1.0f);
        }
        if (Col.gameObject.tag == "A#")
        {
            playerAudio.PlayOneShot(ASharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "B")
        {
            playerAudio.PlayOneShot(B_Key, 1.0f);
        }
        if (Col.gameObject.tag == "Button-Play")
        {
            playerAudio.PlayOneShot(Piano_SmokeOnTheWater, 0.3f);
        }

        //Practice Piano
        if (Col.gameObject.tag == "Practice_C")
        {
            playerAudio.PlayOneShot(C_Key, 1.0f);
        }
        if (Col.gameObject.tag == "Practice_C#")
        {
            playerAudio.PlayOneShot(CSharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "Practice_D")
        {
            playerAudio.PlayOneShot(D_Key, 1.0f);
        }
        if (Col.gameObject.tag == "Practice_D#")
        {
            playerAudio.PlayOneShot(DSharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "Practice_E")
        {
            playerAudio.PlayOneShot(E_Key, 1.0f);
        }
        if (Col.gameObject.tag == "Practice_F")
        {
            playerAudio.PlayOneShot(F_Key, 1.0f);
        }
        if (Col.gameObject.tag == "Practice_F#")
        {
            playerAudio.PlayOneShot(FSharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "Practice_G")
        {
            playerAudio.PlayOneShot(G_Key, 1.0f);
        }
        if (Col.gameObject.tag == "Practice_G#")
        {
            playerAudio.PlayOneShot(GSharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "Practice_A")
        {
            playerAudio.PlayOneShot(A_Key, 1.0f);
        }
        if (Col.gameObject.tag == "Practice_A#")
        {
            playerAudio.PlayOneShot(ASharp_Key, 1.0f);
        }
        if (Col.gameObject.tag == "Practice_B")
        {

            playerAudio.PlayOneShot(B_Key, 1.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
