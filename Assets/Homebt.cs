using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Homebt : MonoBehaviour
{
    public void GoHome()
    {
        SceneManager.LoadScene("StartMenu");
    }
}