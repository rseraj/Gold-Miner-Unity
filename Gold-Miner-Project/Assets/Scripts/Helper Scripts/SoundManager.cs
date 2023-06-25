using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField]
    private AudioSource gold, stone, reyLaugh,
        pullSound, ropeStretch, timeOut, gameEnd;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void Gold()
    {
        gold.Play();
    }

    public void Stone()
    {
       stone.Play();
    }

    public void ReyLaugh()
    {
        reyLaugh.Play();
    }

    public void RopeStretch(bool play)
    {

        if (play)
        {

            if (!ropeStretch.isPlaying)
            {
                ropeStretch.Play();
            }

        }
        else
        {

            if (ropeStretch.isPlaying)
            {
                ropeStretch.Stop();
            }

        }

    }

    public void PullSound(bool play)
    {

        if (play)
        {

            if (!pullSound.isPlaying)
            {
                pullSound.Play();
            }

        }
        else
        {

            if (pullSound.isPlaying)
            {
                pullSound.Stop();
            }

        }

    }

    public void TimeOut(bool play)
    {

        if (play)
        {

            if (!timeOut.isPlaying)
            {
                timeOut.Play();
            }

        }
        else
        {

            if (timeOut.isPlaying)
            {
                timeOut.Stop();
            }

        }

    }

    public void GameEnd()
    {
        gameEnd.Play();
    }

} 






















