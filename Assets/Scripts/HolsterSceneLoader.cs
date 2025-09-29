using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolsterSceneLoader : MonoBehaviour
{
    public GameObject[] weapons = null;
    // Start is called before the first frame update
    void Start()
    {
        if (DontDestroyCleaner.weaponChoice.Equals("Sword"))
        {
            weapons[0].SetActive(true);
        }
        else if (DontDestroyCleaner.weaponChoice.Equals("Axe"))
        {
            weapons[1].SetActive(true);
        }
        else if (DontDestroyCleaner.weaponChoice.Equals("Dagger"))
        {
            weapons[2].SetActive(true);
        }
    }

}
