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
        textfield.text = "The demon’s conquest has brought chaos and suffering to this world";
        yield return new WaitForSeconds(7);
        textfield.text = "and you have made it your life’s goal to end his reign";
        yield return new WaitForSeconds(7);
        textfield.text = "Your journey till now has gifted you this mighty weapon";
        yield return new WaitForSeconds(8);
        textfield.text = "the MACGUFFIN";
        yield return new WaitForSeconds(4);
        textfield.text = "but first we need information.";
        yield return new WaitForSeconds(6);
        textfield.text = "This bar keep notoriously hates heroes";
        yield return new WaitForSeconds(8);
        textfield.text = "convincing him to help could be a challenge.";
        yield return new WaitForSeconds(9);
        textfield.text = "let's see how you handle this...";
        yield return new WaitForSeconds(5);
        textfield.text = "";
    }
}
