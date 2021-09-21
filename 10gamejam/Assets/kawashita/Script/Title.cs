using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Title : MonoBehaviour
{
    public SoundManager soundManager;
    //public VolumeController volumeController;
    // Start is called before the first frame update
    void Start()
    {
        soundManager.PlayBgmByName("Acoustic_2");
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Game");
        }
    }
}
