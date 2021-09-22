using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Title : MonoBehaviour
{
    private void Awake()
    {
        if( SoundManager.Instance.playBgm)
        {
            SoundManager.Instance.StopBgm();
        }
    }
    //public SoundManager soundManager;
    //public VolumeController volumeController;
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.Instance.PlayBgmByName("Acoustic_2");
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("aaaaaaaaa"); 
            SceneManager.LoadScene("Game");
        }
    }
}
