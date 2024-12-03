using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    public string SceneName;

    void Update(){
        if(Input.GetKey(KeyCode.P)){
            SceneManager.LoadScene(SceneName);
        }
        if(Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
    }
}
