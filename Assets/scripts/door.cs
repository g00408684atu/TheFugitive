using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door_closed, door_opened, intText, lockedtext;
    public AudioSource open, close;
    public bool opened, locked;
    
    // Remove 'static' so each door tracks its own key state
    public bool keyfound;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (!opened)
            {
                if (!locked)
                {
                    intText.SetActive(true);
                    if (Input.GetKey(KeyCode.E))
                    {
                        door_closed.SetActive(false);
                        door_opened.SetActive(true);
                        intText.SetActive(false);
                        // open.Play();
                        StartCoroutine(repeat());
                        opened = true;
                    }
                }
                else
                {
                    lockedtext.SetActive(true);
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            lockedtext.SetActive(false);
        }
    }

    IEnumerator repeat()
    {
        yield return new WaitForSeconds(4.0f);
        opened = false;
        door_closed.SetActive(true);
        door_opened.SetActive(false);
        // close.Play();
    }

    void Update()
    {
        // Each door updates based on its own keyfound status
        if (keyfound)
        {
            locked = false;
        }
    }
}