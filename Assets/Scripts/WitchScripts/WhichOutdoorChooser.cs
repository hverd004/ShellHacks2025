using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichOutdoorChooser : MonoBehaviour
{
    public WitchOutdoorDialog td;
    public bool once = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Weapon") && once)
        {
            Debug.Log("threaten");
            once = false;
            td.outdoorhitwitch();
        }
        else if (other.gameObject.CompareTag("Pie") && once)
        {
            Debug.Log("Talk");
            once = false;
            td.outdoorpiewitch();
            Destroy(other.gameObject);
        }
        else if(other.gameObject.transform.parent.TryGetComponent<GrabInteractor>(out GrabInteractor g) && !g.HasSelectedInteractable && once)
        {
            Debug.Log("Knock");
            once = false;
            td.outdoorknockwitch();
        }
        else
        {
            Debug.LogWarning(other.gameObject.name);
        }
    }
}
