using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pauseinscene : MonoBehaviour
{
	GameObject PauseMenu;
	bool paused;
	[SerializeField]
	


	void Start()
	{
        paused = false;
		PauseMenu = GameObject.Find("PauseMenu");
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			paused = !paused;
			
		}

		if (paused)
		{
			PauseMenu.SetActive(true);
			Time.timeScale = 0;
		}
		else if (!paused)
		{
			PauseMenu.SetActive(false);
			Time.timeScale = 1;
		}
	}
	 public void Resume()
	{
		paused = false;
		Time.timeScale = 1;
		UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay");
		//Application.LoadLevel(0);

	}
	public void MainMenu()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
		//Application.LoadLevel(1);

	}
	
}

