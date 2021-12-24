using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform playerInfo;
    public TMP_Text scoreText;

    int x = 18;
    void Update()
    {
        scoreText.text = (playerInfo.position.z+x).ToString("0");
    }
}
