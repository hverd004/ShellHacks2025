using Meta.WitAi;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class WitchIndoorDialog : MonoBehaviour
{
    public FadeScript fadeIn = null;
    public FadeScript fadeOut = null;
    public TextMeshProUGUI textfield = null;
    public AudioSource audio = null;
    public AudioClip[] clips = null;
    public GameObject interactor = null;
    public GameObject ingredients = null;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InitialWitchDialog());
    }

    IEnumerator InitialWitchDialog()
    {
        fadeIn.VRtoVRMethod();
        yield return new WaitForSeconds(fadeIn.duration + .5f);
        audio.clip = clips[0];
        audio.Play();
        textfield.text = "Alright, I know of a potion that can take you where you wish";
        yield return new WaitForSeconds(4.5f);
        textfield.text = "Help me make it and it is yours to use";
        yield return new WaitForSeconds(2.75f);
        textfield.text = "All you need to do is add 3 ingredients to this pot";
        yield return new WaitForSeconds(2.5f);
        textfield.text = "and the potion will be brewed.";
        yield return new WaitForSeconds(2f);
        textfield.text = "";
        audio.clip = clips[1];
        audio.Play();
        interactor.SetActive(true);
        ingredients.SetActive(true);
        textfield.text = "First grab some eyes of newt";
        yield return new WaitForSeconds(1.5f);
        textfield.text = "";
    }

    public void startIngredient2()
    {
        StartCoroutine(ogrehand());
    }

    public void startIngredient3()
    {
        StartCoroutine(witchsalt());
    }

    public void startIndoorEnd()
    {
        StartCoroutine(indoorwitchconclusion());
    }

    IEnumerator ogrehand()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[2];
        audio.Play();
        textfield.text = "Now an ogre’s hand";
        yield return new WaitForSeconds(2f);
        textfield.text = "";
    }

    IEnumerator witchsalt()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[3];
        audio.Play();
        textfield.text = "And lastly 1 teaspoon of salt";
        yield return new WaitForSeconds(4.5f);
        textfield.text = "";
    }

    IEnumerator indoorwitchconclusion()
    {
        yield return new WaitForSeconds(1);
        audio.clip = clips[4];
        audio.Play();
        interactor.SetActive(false);
        textfield.text = "There we go";
        yield return new WaitForSeconds(2f);
        textfield.text = "this will take you where you need to go";
        yield return new WaitForSeconds(2f);
        textfield.text = "Now leave me be";
        yield return new WaitForSeconds(1.75f);
        textfield.text = "your silence creeps me out";
        yield return new WaitForSeconds(2f);
        textfield.text = "";
        fadeOut.VRtoVRMethod();
        yield return new WaitForSeconds(fadeIn.duration + .5f);
        SceneManager.LoadScene(5);
    }
}
