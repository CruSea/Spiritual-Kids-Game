using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DavidMenu : MonoBehaviour
{
    public void BackToCharacterMenu()
    {
        SceneManager.LoadScene("CharacterMenu");

    }

    public void PlayDavidAsAShepherd() 
    {
        SceneManager.LoadScene("DavidAsAShepherdScene");

    }

    public void PlayDavidsAnointmentSecene() 
    {
        SceneManager.LoadScene("David'sAnointmentSecene");

    }

    public void PlayDavidVsGolithScene() 
    {
        SceneManager.LoadScene("DavidVsGolithScene");

    }

    public void PlayDavidAsAKingScene() 
    {
        SceneManager.LoadScene("DavidAsAKingScene");

    }
}
