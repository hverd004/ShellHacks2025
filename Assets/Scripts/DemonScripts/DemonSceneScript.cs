using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DemonSceneScript : MonoBehaviour
{
    public FadeScript fadeIn = null;
    public TextMeshProUGUI textfield = null;
    public AudioSource audiosource = null;
    public AudioClip[] audioclips = null;
    Coroutine runsub = null;
    // Start is called before the first frame update
    void Start()
    {
        runsub = StartCoroutine(DemonPie());
    }
    IEnumerator runSubtitles()
    {

        yield return new WaitForSeconds(2);
        audiosource.clip = audioclips[0];
        audiosource.Play();
        textfield.text = "This is it!! The Final Act!! The Great Climax.";
        yield return new WaitForSeconds(4f);
        textfield.text = "The demon lord is right in front of you";
        yield return new WaitForSeconds(2.2f);
        textfield.text = "you’re officially one move away from victory and fame.";
        yield return new WaitForSeconds(3.3f);
        //buffer between two voice files
        yield return new WaitForSeconds(2f);
        audiosource.clip = audioclips[1];
        audiosource.Play();
        textfield.text = "Another foolish hero at my door, another life thrown away trying to oppose me.";
        yield return new WaitForSeconds(5f);
        textfield.text = " I will admit, it’s impressive you’ve made it this far.";
        yield return new WaitForSeconds(4f);
        textfield.text = "Very few have walked these halls with the intent to kill me.";
        yield return new WaitForSeconds(4.4f);
        textfield.text = "For your accomplishment I will offer you this mercy.";
        yield return new WaitForSeconds(4f);
        textfield.text = "Join me,";
        yield return new WaitForSeconds(1.2f);
        textfield.text = "and you will be part of something greater";
        yield return new WaitForSeconds(3.3f);
        textfield.text = "Oppose me, and you’ll die in vain like all the others.";
        yield return new WaitForSeconds(6);
        textfield.text = "";
        
    }

    public IEnumerator DemonPie()
    {
        yield return new WaitForSeconds(2);
        audiosource.clip = audioclips[2];
        audiosource.Play();
        textfield.text = "A pie? Are we serious? You came all this way just to give me a pie.";
        yield return new WaitForSeconds(2.5f);
        textfield.text = "You know, now that I think about it.";
        yield return new WaitForSeconds(2.5f);
        textfield.text = "I’ve lived for centuries and you, hero, are the first to ever get me a gift. ";
        yield return new WaitForSeconds(1.5f);
        textfield.text = "Perhaps I should reevaluate my stance on humanity.";



    }
}
