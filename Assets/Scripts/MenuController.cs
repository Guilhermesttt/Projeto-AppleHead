using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class MenuController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject menuInicial, menuOptions, loadingScreen; 
    public AudioSource selectAudio;
    public string newGameScene;

    public Dropdown resolution;
    public Toggle windowMode, vSync;


    void Start()
    {
        menuInicial.SetActive(false);
        menuOptions.SetActive(false);
        loadingScreen.SetActive(false);

    }
    void Update()
    {
        if (!videoPlayer.isPlaying && Input.anyKeyDown)
        {
            menuInicial.SetActive(true);
            selectAudio.Play();
          

        }
    }

    public void Configurar()
    {
        menuOptions.SetActive(true);
    }


    public void RetornarMenuInicial()
    {
        menuInicial.SetActive(true);
        menuOptions.SetActive(false);
    }
}

    




