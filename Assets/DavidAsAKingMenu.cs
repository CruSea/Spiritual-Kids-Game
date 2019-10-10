using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DavidAsAKingMenu : MonoBehaviour
{

    public AudioClip DavidAsAKingNaration;
    public AudioSource DavidAsAKingNarationAudioSource;

    
    // Start is called before the first frame update
    void Start()
    {   
        DavidAsAKingNarationAudioSource.clip = DavidAsAKingNaration;
        
    }

    public void PlayAudioDavidAsAKingNaration() {
        DavidAsAKingNarationAudioSource.Play();

    }
    public void BackToCharacterMenu()
    {
        SceneManager.LoadScene("CharacterMenu");

    }

    public void BackToDavidMenu()
    {
        SceneManager.LoadScene("David'sMainMenu");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
