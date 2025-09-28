using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TavernDialog : MonoBehaviour
{
    public FadeScript fadeIn = null;
    public TextMeshProUGUI textfield = null;
    public AudioSource audio = null;
    public AudioClip[] clips = null;

    public GameObject fireOp1 = null;
    public GameObject fireOp2 = null;
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
        activatechoices();
    }

    void activatechoices()
    {
        fireOp1.SetActive(true);
        fireOp2.SetActive(true);
    }
}
