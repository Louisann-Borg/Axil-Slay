using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
public void LoadScene()
{
    SceneManager.LoadScene("AxilMain");
}

public void QuitGame()
{
    SceneManager.LoadScene("Main Menu");
}
}
