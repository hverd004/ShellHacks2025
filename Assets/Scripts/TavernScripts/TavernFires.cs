using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TavernFires : MonoBehaviour
{
    public bool choice2 = false;
    public int increment = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Paper"))
        {
            if (!choice2 && increment == 0)
            {
                //first 1
                Debug.Log("NOOOOOO");
                Destroy(other.gameObject);
                increment++;
            }
            else if (choice2 && increment == 0)
            {
                //first 2
                Debug.Log("YESSSSSS");
                Destroy(other.gameObject);
                increment++;
            }
            else if (!choice2 && increment == 1)
            {
                //second 1
                Destroy(other.gameObject);
                increment++;
            }
            else if (choice2 && increment == 1)
            {
                //second 2
                Destroy(other.gameObject);
                increment++;
            }
        }
    }
}
