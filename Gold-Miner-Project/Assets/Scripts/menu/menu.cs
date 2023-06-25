using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public Button start;
    public Button about;
    public Button exit;
    public Toggle mute;

    // Start is called before the first frame update
    void Start()
    {
        start.onClick.AddListener(() =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay"); 
            //Application.LoadLevel("GamePlay");
        });
        about.onClick.AddListener(() =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("About");
            //Application.LoadLevel("About");
        });
        exit.onClick.AddListener(() =>
        {
            Application.Quit();
        });
      
    }
    //public void play_sound()
    //{
      //  AudioListener.pause = !AudioListener.pause;
        //this.GetComponent<AudioSource>().Play();
    //}

}

