using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemScript : MonoBehaviour
{
    public int scoreValue;

    void OnDisable()
    {
        GamePlayManager.instance.DisplayScore(scoreValue);
    }

}