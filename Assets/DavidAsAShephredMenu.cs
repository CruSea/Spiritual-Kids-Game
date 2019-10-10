using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DavidAsAShephredMenu : MonoBehaviour
{

    public AudioClip DavidAsAShephredFirstNaration;
    public AudioClip DavidAsAShephredSecondNaration;
    public AudioSource DavidAsAShephredFirstNarationMusicSource;
    public AudioSource DavidAsAShephredSecondNarationMusicSource;
    public AudioClip RightAnswerClip;
    public AudioClip WrongAnswerClip;
    public AudioSource RightAnswerAudioSource;
    public AudioSource WrongAnswerAudioSource;
    public AudioClip Question1Clip;
    public AudioClip Question2Clip;
    public AudioSource Question1AudioSource;
    public AudioSource Question2AudioSource;




    // Start is called before the first frame update
    void Start()
    {
        DavidAsAShephredFirstNarationMusicSource.clip = DavidAsAShephredFirstNaration;
        DavidAsAShephredSecondNarationMusicSource.clip = DavidAsAShephredSecondNaration;
        Question1AudioSource.clip = Question1Clip;
        Question2AudioSource.clip = Question2Clip;
        RightAnswerAudioSource.clip = RightAnswerClip;
        WrongAnswerAudioSource.clip = WrongAnswerClip;

    }
    public void PlayQuestion1(){
        Question1AudioSource.Play();
    }

    public void PlayQuestion2(){
        Question2AudioSource.Play();
    }

    public void PlayRightAnswer(){
        RightAnswerAudioSource.Play();
    }

    public void PlayWrongAnswer(){
        WrongAnswerAudioSource.Play();
        
    }

    public void PlayAudioDavidShepherdFirstNaration() {
        DavidAsAShephredFirstNarationMusicSource.Play();

    }
    public void PlayAudioDavidShepherdSecondNaration() {
        DavidAsAShephredSecondNarationMusicSource.Play();

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
