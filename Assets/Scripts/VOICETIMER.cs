using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VOICETIMER : MonoBehaviour
{
    public TextMeshProUGUI textfield = null;
    public AudioSource audio = null;
    public AudioClip[] clips = null;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(barkeepthreat());
    }

    IEnumerator runTavernSubtitles()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "What do you think you're doing?";
        yield return new WaitForSeconds(1.75f);
        textfield.text = "You're so desperate for information that you'd kill me?";
        yield return new WaitForSeconds(2f);
        textfield.text = "Fine";
        yield return new WaitForSeconds(1);
        textfield.text = "Rumor has it there is a witch over in the next town who might be able to help you";
        yield return new WaitForSeconds(4.5f);
        textfield.text = "Now get out";
        yield return new WaitForSeconds(1.75f);
        textfield.text = "Take this pie if you want, I dont care either way";
        yield return new WaitForSeconds(2f);
        textfield.text = "just leave";
        yield return new WaitForSeconds(1);
        textfield.text = "";
    }

    IEnumerator outdoorwhichgoodstart()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "Excellent job persuading the bar keep to help";
        yield return new WaitForSeconds(3f);
        textfield.text = "I knew you could do it";
        yield return new WaitForSeconds(2);
        textfield.text = "";
    }

    IEnumerator outdoorwhichbadstart()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "Um. ok. That wasn’t the most… ";
        yield return new WaitForSeconds(4f);
        textfield.text = "elegant solution but it worked i guess";
        yield return new WaitForSeconds(4);
        textfield.text = "";
    }

    IEnumerator outdoorwhichdmstart()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
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
    }

    IEnumerator outdoorWitchPie()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
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

    IEnumerator outdoorWitchKnock()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
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
    IEnumerator outdoorWitchMenace()
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

    IEnumerator indoorWitchDescription()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "Alright, I know of a potion that can take you where you wish";
        yield return new WaitForSeconds(4.5f);
        textfield.text = "Help me make it and it is yours to use";
        yield return new WaitForSeconds(2.75f);
        textfield.text = "All you need to do is add 3 ingredients to this pot";
        yield return new WaitForSeconds(2.5f);
        textfield.text = "nd the potion will be brewed.";
        yield return new WaitForSeconds(2f);
        textfield.text = "";
    }

    IEnumerator eyeofnewt()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "First grab some eyes of newt";
        yield return new WaitForSeconds(1.5f);
        textfield.text = "";
    }

    IEnumerator ogrehand()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "Now an ogre’s hand";
        yield return new WaitForSeconds(2f);
        textfield.text = "";
    }

    IEnumerator witchsalt()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "And lastly 1 teaspoon of salt";
        yield return new WaitForSeconds(4.5f);
        textfield.text = "";
    }

    IEnumerator indoorwitchconclusion()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "There we go";
        yield return new WaitForSeconds(2f);
        textfield.text = "this will take you where you need to go";
        yield return new WaitForSeconds(2f);
        textfield.text = "Now leave me be";
        yield return new WaitForSeconds(1.75f);
        textfield.text = "your silence creeps me out";
        yield return new WaitForSeconds(2f);
        textfield.text = "";
    }

    IEnumerator barkeeptalk()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "Alright, now we're getting somewhere!";
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

    IEnumerator barkeepthreat()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "What do you think you're doing?";
        yield return new WaitForSeconds(4);
        textfield.text = "You're so desperate for information that you'd kill me?";
        yield return new WaitForSeconds(3.5f);
        textfield.text = "Fine.";
        yield return new WaitForSeconds(1);
        textfield.text = "Rumor has it there is a witch";
        yield return new WaitForSeconds(3f);
        textfield.text = "over in the next town who might be able to help you";
        yield return new WaitForSeconds(4);
        textfield.text = "Now get out";
        yield return new WaitForSeconds(2f);
        textfield.text = "Take this pie if you want, i dont care either way";
        yield return new WaitForSeconds(4);
        textfield.text = "just leave";
        yield return new WaitForSeconds(4);
        textfield.text = "";
    }
}
