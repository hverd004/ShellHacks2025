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
            StartCoroutine(td.ThreatChosen());
        }
    }
}
