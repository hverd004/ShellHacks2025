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
    }
}
