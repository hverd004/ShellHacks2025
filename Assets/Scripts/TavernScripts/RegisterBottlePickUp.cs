using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterBottlePickUp : MonoBehaviour
{
    public TavernDialog td;
    public GameObject binteractor;
    bool once = true;
    public GrabInteractor g = null;
    public GrabInteractor g2 = null;

    void Update()
    {
        if (once)
        {
            if (g.HasSelectedInteractable)
            {
                Debug.LogWarning(g.SelectedInteractable.gameObject.name);
                Debug.LogWarning(binteractor.name);
                if (g.SelectedInteractable.gameObject.Equals(binteractor))
                {
                    Debug.Log("Bottle chosen");
                    StartCoroutine(td.BottleChosen());
                }
                once = false;
            }
            else if (g2.HasSelectedInteractable)
            {
                Debug.LogWarning(g.SelectedInteractable.gameObject.name);
                Debug.LogWarning(binteractor.name);
                if (g2.SelectedInteractable.gameObject.Equals(binteractor))
                {
                    Debug.Log("Bottle Chosen");
                    StartCoroutine(td.BottleChosen());
                }
                once = false;
            }
        }
    }
}
