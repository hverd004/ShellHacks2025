using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoidSceneController : MonoBehaviour
{
    public FadeScript fadeIn = null;
    public FadeScript fadeOut = null;
    public GrabInteractor g = null;
    public GrabInteractor g2 = null;
    public TextMeshProUGUI textfield = null;
    // Start is called before the first frame update
    private void Awake()
    {
        if (g.HasSelectedInteractable)
        {
            fadeOut.fadingObjects.Add(g.SelectedInteractable.gameObject.GetComponentInParent<Renderer>());
            g.SelectedInteractable.gameObject.GetComponentInParent<PersistBetweenScenes>().enabled = false;
        }
        else if (g2.HasSelectedInteractable)
        {
            fadeOut.fadingObjects.Add(g2.SelectedInteractable.gameObject.GetComponentInParent<Renderer>());
            g2.SelectedInteractable.gameObject.GetComponentInParent<PersistBetweenScenes>().enabled = false;
        }
    }
    void Start()
    {
        fadeIn.VRtoVRMethod();
        StartCoroutine(beginSpeech());
    }
    IEnumerator beginSpeech()
    {
        yield return new WaitForSeconds(fadeIn.duration + .5f);
        yield return new WaitForSeconds(1);
        textfield.text = "The demon’s conquest has brought chaos and suffering to this world";
        yield return new WaitForSeconds(1);
        fadeOut.VRtoVRMethod();
        yield return new WaitForSeconds(fadeOut.duration + 0.5f);
        DontDestroyCleaner.ClearDontDestroyOnLoad();
        SceneManager.LoadScene(2);
    }
}
