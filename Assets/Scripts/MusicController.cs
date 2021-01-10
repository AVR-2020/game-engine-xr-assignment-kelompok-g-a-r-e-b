using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource Kubus;
    public AudioSource Balok;
    public AudioSource Tabung;
    public AudioSource Limas;
    public AudioSource Bola;

    bool status = false;
    public void playMusic()
    {
        if (PublicObject.activeModel == "Kubus")
        {
            if (!status)
            {
                Kubus.Play();
                status = true;
            }
            else
            {
                Kubus.Stop();
                status = false;
            }
        }
        else if (PublicObject.activeModel == "Balok")
        {
            if (!status)
            {
                Balok.Play();
                status = true;
            }
            else
            {
                Balok.Stop();
                status = false;
            }
        }
        else if (PublicObject.activeModel == "Tabung")
        {
            if (!status)
            {
                Tabung.Play();
                status = true;
            }
            else
            {
                Tabung.Stop();
                status = false;
            }
        }
        else if (PublicObject.activeModel == "Limas")
        {
            if (!status)
            {
                Limas.Play();
                status = true;
            }
            else
            {
                Limas.Stop();
                status = false;
            }
        }
        else if (PublicObject.activeModel == "Bola")
        {
            if (!status)
            {
                Bola.Play();
                status = true;
            }
            else
            {
                Bola.Stop();
                status = false;
            }
        }
    }
}
