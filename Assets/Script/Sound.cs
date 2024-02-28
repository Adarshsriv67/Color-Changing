using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip mainMenu;
    void Start()
    {
        AudioSource.PlayClipAtPoint(mainMenu, Camera.main.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
