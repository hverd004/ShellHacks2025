using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichOutdoorChooser : MonoBehaviour
{
    public WitchOutdoorDialog td;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            Debug.Log("threaten");
            td.outdoorWitchMenace();
        }
        else if (other.gameObject.CompareTag("Pie"))
        {
            Debug.Log("Talk");
            td.outdoorWitchPie();
        }
        else if(other.gameObject.TryGetComponent<GrabInteractor>(out GrabInteractor g) && !g.HasSelectedInteractable)
        {
            Debug.Log("Knock");
            td.outdoorWitchKnock();
        }
    }
}
