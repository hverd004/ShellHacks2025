using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterThreat : MonoBehaviour
{
    public TavernDialog td;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            Debug.Log("threaten");
            td.loadThreats();
        }
        else if (other.gameObject.CompareTag("Bottle"))
        {
            Debug.Log("Talk");
            td.loadBottles();
        }
    }
}
