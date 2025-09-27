using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonSceneScript : MonoBehaviour
{
    public FadeScript fadeIn = null;
    // Start is called before the first frame update
    void Start()
    {
        fadeIn.VRtoVRMethod();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
