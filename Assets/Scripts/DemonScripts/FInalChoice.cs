using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FInalChoice : MonoBehaviour
{
    public DemonSceneScript d = null;
    public bool good = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Weapon") && !good)
        {
            Destroy(other.gameObject);
            ENDINGS.ending = 2;
            SceneManager.LoadScene(6);
        }
        else if (other.gameObject.CompareTag("Weapon") && good)
        {
            Destroy(other.gameObject);
            ENDINGS.ending = 1;
            SceneManager.LoadScene(6);
        }
        else if (other.gameObject.CompareTag("Pie"))
        {
            ENDINGS.ending = 0;
            d.pieDemon();
        }
    }
}
