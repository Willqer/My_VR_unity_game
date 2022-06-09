using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MenuFunctions : MonoBehaviour
{
    //==========================
    [SerializeField] private int RandomScenesCount = 10;
    //==========================
    public void MoveToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void MoveToRandomScene(int min)
    {
        SceneManager.LoadScene(Random.Range(min,min - 1 + RandomScenesCount));
    }
    public void AppQuit()
    {
        Application.Quit();
    }
    //==========================
}
