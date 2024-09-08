using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    public float volumeMaster, volumeFX, volumeMusica;

    public object Musica { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void VolumeMaster(float volume)
    {
        volumeMaster = volume;
        AudioListener.volume = volumeMaster;

    }

    public void VolumeFX(float volume)
    {
        volumeFX = volume;

        GameObject[] FX = GameObject.FindGameObjectsWithTag("FX");
        for(int i = 0; i <FX.Length; i++)
        {
            FX[i].GetComponent<AudioSource>().volume = volumeFX;
        }

    }

    public void VolumeMusica(float volume)
    {
        volumeMusica = volume;

        GameObject[] Musica = GameObject.FindGameObjectsWithTag("Musica");
        for (int i = 0; i < Musica.Length; i++)
        {
            Musica[i].GetComponent<AudioSource>().volume = volumeMusica;
        }


    }

}
