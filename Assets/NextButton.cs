using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene("ScoreScene");
    }
}