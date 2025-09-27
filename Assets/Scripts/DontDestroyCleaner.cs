using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class DontDestroyCleaner : MonoBehaviour
{
    public static string weaponChoice = null;
    public static void ClearDontDestroyOnLoad()
    {
        // Create a temporary GameObject so we can find the DontDestroyOnLoad scene
        GameObject temp = new GameObject("Temp");
        DontDestroyOnLoad(temp);

        Scene dontDestroyScene = temp.scene; // This is the special scene
        DestroyImmediate(temp);

        List<GameObject> toDestroy = new List<GameObject>();
        foreach (GameObject go in dontDestroyScene.GetRootGameObjects())
        {
            toDestroy.Add(go);
            Debug.Log(go.name);
            if (go.name.Equals("Weapons"))
            {
                if (go.gameObject.transform.GetChild(0).gameObject.activeSelf == true)
                {
                    weaponChoice = "Sword";
                }
                if (go.gameObject.transform.GetChild(1).gameObject.activeSelf == true)
                {
                    weaponChoice = "Axe";
                }
                if (go.gameObject.transform.GetChild(2).gameObject.activeSelf == true)
                {
                    weaponChoice = "Dagger";
                }
            }
        }

        // Destroy them safely
        foreach (GameObject go in toDestroy)
        {
            Destroy(go);
        }
    }
}
