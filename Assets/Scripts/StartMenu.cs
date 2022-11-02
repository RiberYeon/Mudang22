using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject playButton;
    public GameObject WayButton;
    public GameObject Help;
    public void GameStart()
    {
        AudioSource playButtonP = playButton.GetComponent<AudioSource>();
        playButtonP.Play();
        SceneManager.LoadScene("StageScene");
    }

    public void GameHelp()
    {
        AudioSource playButtonQ = playButton.GetComponent<AudioSource>();
        playButtonQ.Play();
        if (!Help.activeSelf)
        {
            Help.SetActive(true);
        }
    }
  

    public void Update()
    {
        if(Help.activeSelf && Input.GetMouseButtonDown(0))
        {
            Help.SetActive(false);
        }
    }
    

}
