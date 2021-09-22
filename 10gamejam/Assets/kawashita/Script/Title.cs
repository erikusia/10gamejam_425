using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Title : MonoBehaviour
{
    [SerializeField] private Button gameButton;
    [SerializeField] private Button OnryoButton;
    [SerializeField]
    private GameObject gameUI;
    [SerializeField]
    private GameObject onryoUI;
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
        OnryoButton.onClick.AddListener(Onryo);
        gameButton.onClick.AddListener(gameScene);
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

    private void gameScene()
    {
        SceneManager.LoadScene("Game");
    }

    private void Onryo()
    {

    }
}
