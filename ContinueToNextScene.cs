using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ContinueToNextScene : MonoBehaviour
{
    [SerializeField] private string Scene;

    private ControlsMap mapping;
    //==========================
    private void OnEnable()
    {
        mapping.Enable();
    }
    private void OnDisable()
    {
        mapping.Disable();
    }
    //==========================
    private void Awake()
    {
        mapping = new ControlsMap();
        mapping.Menu.Continue.performed += context => LoadScene();
    }
    void Update()
    {
        if (Input.GetButtonDown("Akey")      || Input.GetButtonDown("Bkey")      ||
            Input.GetButtonDown("Ckey")      || Input.GetButtonDown("Dkey")      ||
            Input.GetButtonDown("UpTrigger") || Input.GetButtonDown("DownTrigger"))
        {
            LoadScene();
        }
    }
    //==========================
    private void LoadScene()
    {
        SceneManager.LoadScene(Scene);
    }
}
