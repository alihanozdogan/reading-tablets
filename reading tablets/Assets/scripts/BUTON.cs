using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUTON : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void changescene()
    {
        SceneManager.LoadScene("Math");
    }
    public void aboutus()
    {
        SceneManager.LoadScene("ABOUT");
    }
    public void settings()
    {
        SceneManager.LoadScene("settings");
    }
    public void free()
    {
        SceneManager.LoadScene("free");
    }
    public void sentences()
    {
        SceneManager.LoadScene("sentences");
    }
    public void MUTE()
    {
        AudioListener.pause = !AudioListener.pause;
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
    public void changesceneTablet()
    {
        SceneManager.LoadScene("tablet");
    }
}
