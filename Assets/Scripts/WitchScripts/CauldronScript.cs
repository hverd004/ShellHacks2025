using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronScript : MonoBehaviour
{
    public WitchIndoorDialog d = null;
    int num = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(num == 0 && other.gameObject.CompareTag("Newt"))
        {
            Destroy(other.gameObject);
            num++;
            d.startIngredient2();
        }
        else if(num == 1 && other.gameObject.CompareTag("Ogre"))
        {
            Destroy(other.gameObject);
            num++;
            d.startIngredient3();
        }
        else if (num == 2 && other.gameObject.CompareTag("Salt"))
        {
            Destroy(other.gameObject);
            num++;
            d.startIndoorEnd();
        }
    }

}
