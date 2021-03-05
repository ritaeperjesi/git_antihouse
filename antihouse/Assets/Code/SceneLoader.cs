using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string loadLevelr;
    public float timeInScene;
    float timerr ;
    // Start is called before the first frame update
    void Start()
    {
        timerr = 0f;


}

    // Update is called once per frame
    void Update()
    {
        //if audio ends
        timerr += Time.deltaTime;
        if (timerr >= timeInScene)
        {
            SceneManager.LoadScene(loadLevelr);
            timerr = 0f;
        }
    }
}
