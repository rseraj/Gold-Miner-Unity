using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayManager : MonoBehaviour
{
    private PlayerAnimation playerAnim;
    public static GamePlayManager instance;

    [SerializeField]
    private Text countdownText;

    public int countdownTimer = 60;
 

    [SerializeField]
    private Text scoreText;

    private int scoreCount;

    [SerializeField]
    private Image scoreFillUI;

    void Awake()
    {
        
        if (instance == null)
            instance = this;
        playerAnim = GetComponentInParent<PlayerAnimation>();
    }

    // Start is called before the first frame update
    void Start()
     {

    DisplayScore(0);

    countdownText.text = countdownTimer.ToString();

    StartCoroutine("Countdown");
       
    }
   

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(1f);

        countdownTimer -= 1;

        countdownText.text = countdownTimer.ToString();

        if (countdownTimer <= 10)
        {
            SoundManager.instance.TimeOut(true);
        }

        StartCoroutine("Countdown");

        if (countdownTimer <= 0)
        {
            StopCoroutine("Countdown");

            SoundManager.instance.GameEnd();
            SoundManager.instance.TimeOut(false);

            //StartCoroutine(RestartGame());
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lose");
           // Application.LoadLevel("Lose");
        }

         } // countdown

        public void DisplayScore(int scoreValue)
        {
            if (scoreText == null)
                return;

            scoreCount += scoreValue;
            scoreText.text = "$ " + scoreCount;

            scoreFillUI.fillAmount = (float)scoreCount / 100f;
        //98/100=0.98
            if (scoreCount >= 100)
            {
                StopCoroutine("Countdown");
                SoundManager.instance.GameEnd();

            //playerAnim.ChearAnimation();
            // StartCoroutine(RestartGame());
            UnityEngine.SceneManagement.SceneManager.LoadScene("Win");
            //Application.LoadLevel("Win");
        }

        }

        IEnumerator RestartGame()
        {
            yield return new WaitForSeconds(4f);

            UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay");
        }

    } // class

//}


