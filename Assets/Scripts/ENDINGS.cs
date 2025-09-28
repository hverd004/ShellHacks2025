using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ENDINGS : MonoBehaviour
{
    public static int ending = 2;
    public TextMeshProUGUI textfield = null;
    public AudioSource audiosource = null;
    public AudioClip[] audioclips = null;
    public FadeScript f = null;
    private void Start()
    {
        if (ending == 0)
        {
            f.VRtoVRMethod();
            StartCoroutine(ending1());
        }
        else if (ending == 1)
        {
            f.VRtoVRMethod();
            StartCoroutine(ending2());
        }
        else if(ending == 2)
        {
            f.VRtoVRMethod();
            StartCoroutine(ending3());
        }
    }

    IEnumerator ending1()
    {
        yield return new WaitForSeconds(1);
        audiosource.clip = audioclips[0];
        audiosource.Play();
        textfield.text = "I… but… how did… why did… sure.";
        yield return new WaitForSeconds(8f);
        textfield.text = "Um, and with that an era of peace emerges";
        yield return new WaitForSeconds(6);
        textfield.text = "and every 14th of March they celebrate your actions or something I don’t know";
        yield return new WaitForSeconds(6);
        textfield.text = "I think I’m done playing for today...";
        yield return new WaitForSeconds(2);
        textfield.text = "Good job I guess";
        yield return new WaitForSeconds(4);
    }
    IEnumerator ending2()
    {
        yield return new WaitForSeconds(1);
        audiosource.clip = audioclips[1];
        audiosource.Play();
        textfield.text = "YOU STRIKE AT THE DEMON KING AND WITH YOUR GREAT RESOLVE";
        yield return new WaitForSeconds(4.5f);
        textfield.text = "YOU VANQUISH THIS ANCIENT EVIL BRINGING AN ERA OF PEACE TO HUMANITY";
        yield return new WaitForSeconds(5);
        textfield.text = "Great job player, a truly marvelous display of heroics";
        yield return new WaitForSeconds(4);
        textfield.text = "I couldn’t have wished for a better campaign if I tried";
        yield return new WaitForSeconds(4);
        textfield.text = "thank you for playing";
        yield return new WaitForSeconds(1.5f);
        textfield.text = "I hope you had as much fun as I have";
        yield return new WaitForSeconds(2);
    }
    IEnumerator ending3()
    {
        yield return new WaitForSeconds(0.5f);
        audiosource.clip = audioclips[2];
        audiosource.Play();
        textfield.text = "HOLD UP. THAT’S NOT HOW YOU PLAY THE GAME";
        yield return new WaitForSeconds(4f);
        textfield.text = "WHY WOULD YOU DO THAT? THIS WHOLE JOURNEY";
        yield return new WaitForSeconds(2.8f);
        textfield.text = "JUST TO JOIN THE BIG BAD AT THE END";
        yield return new WaitForSeconds(2.8f);
        textfield.text = "THIS IS NOT HOW YOU PLAY A HERO";
        yield return new WaitForSeconds(2.8f);
        textfield.text = "YOU SHOULD BE ASHAMED YOU… YOU VILLAN";
        yield return new WaitForSeconds(2.8f);
        textfield.text = "What a waste of a perfectly good campaign";
        yield return new WaitForSeconds(3);
        textfield.text = "Begone you menace";
        yield return new WaitForSeconds(3);
    }
}
