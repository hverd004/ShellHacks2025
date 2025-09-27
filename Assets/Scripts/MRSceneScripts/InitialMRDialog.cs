using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class InitialMRDialog : MonoBehaviour
{
    public TextMeshProUGUI textfield = null;

    Coroutine runsub = null;
    // Start is called before the first frame update
    void Start()
    {
        runsub = StartCoroutine(runSubtitles());
    }
    IEnumerator runSubtitles()
    {
        yield return new WaitForSeconds(1);
        textfield.text = "Oh, a new adventurer!";
        yield return new WaitForSeconds(3);
        textfield.text = "Welcome!";
        yield return new WaitForSeconds(2);
        textfield.text = "As your Dungeon Master";
        yield return new WaitForSeconds(2);
        textfield.text = "I've crafted an epic campaign for your enjoyment.";
        yield return new WaitForSeconds(6);
        textfield.text = "To begin, choose the weapon that speaks to you the most.";
        yield return new WaitForSeconds(15);
        textfield.text = "I'll wait...";
        yield return new WaitForSeconds(3);
        textfield.text = "";
    }

    public IEnumerator swordChosen(FadeScript f, InitialWeaponGrab mw)
    {
        if(runsub != null)
        {
            StopCoroutine(runsub);
            runsub = null;
        }
        yield return new WaitForSeconds(1);
        textfield.text = "Ah, A sword, a true classic";
        yield return new WaitForSeconds(3);
        textfield.text = "best fitting of a hero";
        yield return new WaitForSeconds(2);
        textfield.text = "now let’s begin";
        yield return new WaitForSeconds(3);
        textfield.text = "";
        f.MRtoVRMethod();
        StartCoroutine(mw.loadNextScene());
    }

    public IEnumerator axeChosen(FadeScript f, InitialWeaponGrab mw)
    {
        if (runsub != null)
        {
            StopCoroutine(runsub);
            runsub = null;
        }
        yield return new WaitForSeconds(1);
        textfield.text = "Ah, A battle axe,";
        yield return new WaitForSeconds(3);
        textfield.text = "may your hits be critical";
        yield return new WaitForSeconds(2);
        textfield.text = "now let’s begin";
        yield return new WaitForSeconds(3);
        textfield.text = "";
        f.MRtoVRMethod();
        StartCoroutine(mw.loadNextScene());
    }

    public IEnumerator daggerChosen(FadeScript f, InitialWeaponGrab mw)
    {
        if (runsub != null)
        {
            StopCoroutine(runsub);
            runsub = null;
        }
        yield return new WaitForSeconds(1);
        textfield.text = "Ah, A dagger";
        yield return new WaitForSeconds(3);
        textfield.text = "you must be quick witted";
        yield return new WaitForSeconds(2);
        textfield.text = "and with that let’s begin";
        yield return new WaitForSeconds(4);
        textfield.text = "";
        f.MRtoVRMethod();
        StartCoroutine(mw.loadNextScene());
    }
}
