using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;
using UnityEngine.SceneManagement;

public class InitialWeaponGrab : MonoBehaviour
{
    public FadeScript f = null;
    bool once = true;
    public GrabInteractor g = null;
    public GrabInteractor g2 = null;
    public InitialMRDialog md = null;
    // Update is called once per frame
    void Update()
    {
        if (once)
        {
            if (g.HasSelectedInteractable)
            {
                string grabbedObject = g.SelectedInteractable.gameObject.transform.parent.name;
                Debug.Log(grabbedObject);
                if (grabbedObject.Equals("Sword")){
                    f.fadingObjects.RemoveAt(0);
                    StartCoroutine(md.swordChosen(f, this));
                }
                else if (grabbedObject.Equals("Axe"))
                {
                    f.fadingObjects.RemoveAt(1);
                    StartCoroutine(md.axeChosen(f, this));
                }
                else if (grabbedObject.Equals("Dagger"))
                {
                    f.fadingObjects.RemoveAt(2);
                    StartCoroutine(md.daggerChosen(f, this));
                }
                once = false;
            }
            else if (g2.HasSelectedInteractable)
            {
                string grabbedObject = g2.SelectedInteractable.gameObject.transform.parent.name;
                Debug.Log(grabbedObject);
                if (grabbedObject.Equals("Sword"))
                {
                    f.fadingObjects.RemoveAt(0);
                    StartCoroutine(md.swordChosen(f, this));
                }
                else if (grabbedObject.Equals("Axe"))
                {
                    f.fadingObjects.RemoveAt(1);
                    StartCoroutine(md.axeChosen(f, this));
                }
                else if (grabbedObject.Equals("Dagger"))
                {
                    f.fadingObjects.RemoveAt(2); 
                    StartCoroutine(md.daggerChosen(f, this));
                }
                once = false;
            }
        }
    }

    public IEnumerator loadNextScene()
    {
        yield return new WaitForSeconds(f.duration + 0.5f);
        SceneManager.LoadScene(1);
    }
}
