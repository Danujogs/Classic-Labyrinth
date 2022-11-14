using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("BGM");
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

        // GameObject[] sfxObj = GameObject.FindGameObjectsWithTag("SFX");
        // if (sfxObj.Length > 1)
        // {
        //     Destroy(this.gameObject);
        // }
        // DontDestroyOnLoad(this.gameObject);
    }
}
