using Meta.WitAi;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class WitchOutdoorDialog : MonoBehaviour
{
    public FadeScript fadeIn = null;
    public FadeScript fadeOut = null;
    public TextMeshProUGUI textfield = null;
    public AudioSource audio = null;
    public AudioClip[] clips = null;
    public static bool good = false;
    public GameObject interactor = null;
    // Start is called before the first frame update
    void Start()
    {
        if (good)
        {
            StartCoroutine(InitialGoodWitchDialog());
        }
        else
        {
            StartCoroutine(InitialBadWitchDialog());
        }
    }

    IEnumerator InitialGoodWitchDialog()
    {
        fadeIn.VRtoVRMethod();
        yield return new WaitForSeconds(fadeIn.duration + .5f);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "Excellent job persuading the bar keep to help";
        yield return new WaitForSeconds(3f);
        textfield.text = "I knew you could do it";
        yield return new WaitForSeconds(2);
        textfield.text = "";
        StartCoroutine(outdoorwhichdmstart());
    }

    IEnumerator InitialBadWitchDialog()
    {
        fadeIn.VRtoVRMethod();
        yield return new WaitForSeconds(fadeIn.duration + .5f);
        audio.clip = clips[1];
        audio.Play();
        textfield.text = "Um. ok. That wasn’t the most… ";
        yield return new WaitForSeconds(4f);
        textfield.text = "elegant solution but it worked i guess";
        yield return new WaitForSeconds(4);
        textfield.text = "";
        StartCoroutine(outdoorwhichdmstart());
    }

    IEnumerator outdoorwhichdmstart()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[2];
        audio.Play();
        textfield.text = "You now find yourself in front of the witches' hut";
        yield return new WaitForSeconds(3f);
        textfield.text = "Although you are excited to be one step closer to your goal";
        yield return new WaitForSeconds(3f);
        textfield.text = "the witch doesn't seem to share that excitement";
        yield return new WaitForSeconds(2.25f);
        textfield.text = "as she demands you leave her alone";
        yield return new WaitForSeconds(2.25f);
        textfield.text = "How do you persuade her to help?";
        yield return new WaitForSeconds(2);
        textfield.text = "";
        loadObjects();
    }

    void loadObjects()
    {
        interactor.SetActive(true);
    }

    public IEnumerator outdoorWitchPie()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[3];
        audio.Play();
        textfield.text = "My pie orb is reacting, you wouldn’t happen to have a pie with you?";
        yield return new WaitForSeconds(6f);
        textfield.text = "You do! Well… I suppose I could help you just this once.";
        yield return new WaitForSeconds(1.25f);
        textfield.text = "You do! Well... I suppose I could help you just this once.";
        yield return new WaitForSeconds(2.5f);
        textfield.text = "Come in, and bring that pie with you.";
        yield return new WaitForSeconds(2.25f);
        textfield.text = "";
    }

    public IEnumerator outdoorWitchKnock()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[4];
        audio.Play();
        textfield.text = "Do you plan on knocking on my door for the whole dang day?";
        yield return new WaitForSeconds(4.5f);
        textfield.text = "If I tell you what you want will you leave me alone?";
        yield return new WaitForSeconds(4f);
        textfield.text = "Fine, come in";
        yield return new WaitForSeconds(2f);
        textfield.text = "Let’s make this quick";
        yield return new WaitForSeconds(2f);
        textfield.text = "";
    }

    public IEnumerator outdoorWitchMenace()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "MY DOOR?";
        yield return new WaitForSeconds(1.5f);
        textfield.text = "Do you know how much a mahogany door costs?";
        yield return new WaitForSeconds(3.5f);
        textfield.text = "You think you’re so tough huh?";
        yield return new WaitForSeconds(3.75f);
        textfield.text = "Let’s see how tough you are when the demons’ rip you to shreds!";
        yield return new WaitForSeconds(6f);
        textfield.text = "";
    }
}
