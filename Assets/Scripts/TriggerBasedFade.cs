using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBasedFade : MonoBehaviour
{
    public FadeScript f = null;
    private void OnTriggerEnter(Collider other)
    {
        f.MRtoVRMethod();
    }
}
