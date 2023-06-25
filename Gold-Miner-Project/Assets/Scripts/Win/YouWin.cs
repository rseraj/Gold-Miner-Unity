using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWin : MonoBehaviour
{
    public Button rreturn;
    public Button aagain;
    // Start is called before the first frame update
    void Start()
    {
        rreturn.onClick.AddListener(() =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay");
            //Application.LoadLevel("GamePlay");
        });
        aagain.onClick.AddListener(() =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
           // Application.LoadLevel("Main");
        });
    }


    void Update()
    {

    }

}
