using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public AudioClip WIN;
    public AudioClip Piano_SmokeOnTheWater;
    public AudioClip WRONG;
    private AudioSource playerAudio;
    public List<string> Song;

    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        Song.Add("C");
        Song.Add("D#");
        Song.Add("F");
        Song.Add("C");
        Song.Add("D#");
        Song.Add("F#");
        Song.Add("F");
        Song.Add("C");
        Song.Add("D#");
        Song.Add("F");
        Song.Add("D#");
        Song.Add("C");
        playerAudio.PlayOneShot(Piano_SmokeOnTheWater, 0.4f);
    }


    void OnTriggerEnter(Collider other)
    {
        if (Song.Count > 0)
        {
            if (other.gameObject.tag == Song[0])
            {
                Song.Remove(Song[0]);
                if (Song.Count == 0)
                {
                    playerAudio.PlayOneShot(WIN, 0.5f);
                }
            }
            else if ((other.gameObject.tag == "Button-Play") || (other.gameObject.tag == "Practice_C") || (other.gameObject.tag == "Practice_C#") || (other.gameObject.tag == "Practice_D") || (other.gameObject.tag == "Practice_D#") || (other.gameObject.tag == "Practice_E") || (other.gameObject.tag == "Practice_F") || (other.gameObject.tag == "Practice_F#") || (other.gameObject.tag == "Practice_G") || (other.gameObject.tag == "Practice_G#") || (other.gameObject.tag == "Practice_A") || (other.gameObject.tag == "Practice_A#") || (other.gameObject.tag == "Practice_B"))
            {
                return;
            }

            else
            {
                playerAudio.PlayOneShot(WRONG, 1.0f);
                Song.Clear();
                Song.Add("C");
                Song.Add("D#");
                Song.Add("F");
                Song.Add("C");
                Song.Add("D#");
                Song.Add("F#");
                Song.Add("F");
                Song.Add("C");
                Song.Add("D#");
                Song.Add("F");
                Song.Add("D#");
                Song.Add("C");
            }
        }

    }
}


