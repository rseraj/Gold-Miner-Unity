using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouLose : MonoBehaviour
{
    public Button retturn;
    public Button agaain;
    // Start is called before the first frame update
    void Start()
    {
        retturn.onClick.AddListener(() =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay");
           // Application.LoadLevel("GamePlay");
        });
        agaain.onClick.AddListener(() =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
           // Application.LoadLevel("Main");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
