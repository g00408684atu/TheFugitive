using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript : MonoBehaviour
{
    public GameObject inticon, key, arrow1, arrow2, arrow3, monster;
    public List<Door> doorsToUnlock;

    // Flag to determine if this key activates monster/arrows
    public bool triggersMonsterAndArrows = false;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                key.SetActive(false);
                inticon.SetActive(false);

                // Unlock only the assigned doors
                foreach (Door door in doorsToUnlock)
                {
                    door.keyfound = true;
                }

                // Activate monster and arrows only if this key is supposed to
                if (triggersMonsterAndArrows)
                {
                    arrow1.SetActive(true);
                    arrow2.SetActive(true);
                    arrow3.SetActive(true);
                    monster.SetActive(true);
                }
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