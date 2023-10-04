using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeExit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update");

        if (Input.GetKeyDown(KeyCode.Escape))
            GameQuit();
    }

    public void GameQuit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Debug.Log("Application Quit");
        Application.Quit();
        #endif
    }
}
