using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip BackgroundMusic;
    public AudioSource BackgroundMusicSource; 

    // Start is called before the first frame update
    void Start()
    {
        BackgroundMusicSource.clip = BackgroundMusic;
        BackgroundMusicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.Space))
        //     MusicSource.Play();
    }
}
