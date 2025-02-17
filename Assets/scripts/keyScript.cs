using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript : MonoBehaviour
{
    public GameObject inticon, key , arrow1 , arrow2 , arrow3, monster;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                key.SetActive(false);
                Door.keyfound = true;
                inticon.SetActive(false);
                arrow1.SetActive(true);
                arrow2.SetActive(true);
                arrow3.SetActive(true);
                monster.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(false);
        }
    }
}
