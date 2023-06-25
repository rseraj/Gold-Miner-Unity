using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class About : MonoBehaviour
{
    public Button returnn;
    // Start is called before the first frame update
    void Start()
    {
        returnn.onClick.AddListener(() =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
            //Application.LoadLevel("Main");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
