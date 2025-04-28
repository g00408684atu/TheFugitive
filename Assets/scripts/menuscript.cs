using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    public string SceneName;

    void Update(){
        if(Input.GetKeyDown(KeyCode.P)){
            SceneManager.LoadScene(SceneName);
        }
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }
}
