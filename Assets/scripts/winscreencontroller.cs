using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenController : MonoBehaviour
{
    void Update()
    {
        // Press P to play
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("TheFugitive");
        }

        // Press Escape to quit
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}