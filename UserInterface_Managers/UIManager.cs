using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text txtScore;

    private void Start()
    {
        txtScore.text = "0";
    }

    public void ChangeScore(int score)
    {
        txtScore.text = score.ToString();
    }
}