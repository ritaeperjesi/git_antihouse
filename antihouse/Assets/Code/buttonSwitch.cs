using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonSwitch : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            print("reload scene");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    public void RefreshScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
