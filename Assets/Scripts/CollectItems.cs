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


    public IEnumerator OpenDoors(string tagName, float distance)
    {
        // Find the object with the specified tag
        GameObject door = GameObject.FindGameObjectWithTag(tagName);

        if (door == null)
        {
            Debug.LogError("Object with tag '" + tagName + "' not found.");
            yield break;
        }

        // Set the speed at which the door will move
        float speed = 0.025f;

        // Calculate the number of frames needed to move the door the total distance
        int numFrames = Mathf.CeilToInt(Mathf.Abs(distance) / speed);

        // Calculate the direction in which to move the door
        Vector3 direction = distance > 0 ? Vector3.forward : Vector3.back;

        // Move the door by a small amount each frame
        for (int i = 0; i < numFrames; i++)
        {
            door.transform.Translate(direction * speed);
            yield return null;
        }
    }

    public void ChangeDoorLightColor(Color newColor)
    {
        foreach (GameObject light in GameObject.FindGameObjectsWithTag("Light_Door"))
        {
            light.GetComponent<Light>().color = newColor;
        }
    }

    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        Song.Add("C");
        //Song.Add("D#");
        //Song.Add("F");
        //Song.Add("C");
        //Song.Add("D#");
        //Song.Add("F#");
        //Song.Add("F");
        //Song.Add("C");
        //Song.Add("D#");
        //Song.Add("F");
        //Song.Add("D#");
        //Song.Add("C");
        //playerAudio.PlayOneShot(Piano_SmokeOnTheWater, 0.3f
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
                    playerAudio.PlayOneShot(WIN, 0.6f);
                    StartCoroutine(OpenDoors("Door_Left", 2.5f));
                    StartCoroutine(OpenDoors("Door_Right", -2.5f));
                    ChangeDoorLightColor(Color.green);

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
                //Song.Add("D#");
                //Song.Add("F");
                //Song.Add("C");
                //Song.Add("D#");
                //Song.Add("F#");
                //Song.Add("F");
                //Song.Add("C");
                //Song.Add("D#");
                //Song.Add("F");
                //Song.Add("D#");
                //Song.Add("C");
            }
        }

    }
}


