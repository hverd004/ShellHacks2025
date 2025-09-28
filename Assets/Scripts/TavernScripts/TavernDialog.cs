using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TavernDialog : MonoBehaviour
{
    public FadeScript fadeIn = null;
    public FadeScript fadeOut = null;
    public TextMeshProUGUI textfield = null;
    public AudioSource audio = null;
    public AudioClip[] clips = null;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(start());
    }

    IEnumerator start()
    {
        fadeIn.VRtoVRMethod();
        yield return new WaitForSeconds(fadeIn.duration + .5f);
        StartCoroutine(runTavernSubtitles());
    }

    IEnumerator runTavernSubtitles()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "You approach the tavern with a daunting mission";
        yield return new WaitForSeconds(3);
        textfield.text = "as you walk towards the barkeep.";
        yield return new WaitForSeconds(2f);
        textfield.text = "This barkeep notoriously hates heroes, and convincing him";
        yield return new WaitForSeconds(3);
        textfield.text = "to give you any useful information for your quest could be difficult.";
        yield return new WaitForSeconds(4);
        textfield.text = "how do you handle this...";
        yield return new WaitForSeconds(2);
        textfield.text = "";
        yield return new WaitForSeconds(2);
        audio.clip = clips[1];
        audio.Play();
        textfield.text = "Oh great, another ‘hero’";
        yield return new WaitForSeconds(3);
        textfield.text = "Either buy a drink or get out";
        yield return new WaitForSeconds(2);
        textfield.text = "I’m not here to talk with people like you";
        yield return new WaitForSeconds(3);
        textfield.text = "";
    }


    public IEnumerator BottleChosen()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[2];
        audio.Play();
        textfield.text = "Alright, now we’re getting somewhere!";
        yield return new WaitForSeconds(4);
        textfield.text = "Let me guess, you're gonna ask about those demons arent you";
        yield return new WaitForSeconds(3.5f);
        textfield.text = "Every one of you heroes always want the same thing.";
        yield return new WaitForSeconds(4);
        textfield.text = "Sorry I don’t know much, but I do believe";
        yield return new WaitForSeconds(3f);
        textfield.text = "there is a witch a town over who might be able to help you";
        yield return new WaitForSeconds(4);
        textfield.text = "If it makes you feel better you can have this pie";
        yield return new WaitForSeconds(2f);
        textfield.text = "a gift from me to you for your patronage";
        yield return new WaitForSeconds(4);
        textfield.text = "";
    }

    public IEnumerator ThreatChosen()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[2];
        audio.Play();
        textfield.text = "";
        yield return new WaitForSeconds(4);
        textfield.text = "";
        yield return new WaitForSeconds(4.5f);
        textfield.text = "";
        yield return new WaitForSeconds(3f);
    }
}
