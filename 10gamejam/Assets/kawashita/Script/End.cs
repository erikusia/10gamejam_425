using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    [SerializeField] private Button gameButton;
    [SerializeField] private Button OnryoButton;
    [SerializeField]
    private GameObject gameUI;
    [SerializeField]
    private GameObject onryoUI;
    private void Awake()
    {
        if (SoundManager.Instance.playBgm)
        {
            SoundManager.Instance.StopBgm();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameButton.onClick.AddListener(gameScene);
        OnryoButton.onClick.AddListener(Onryo);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void gameScene()
    {
        SceneManager.LoadScene("Game");
    }

    private void Onryo()
    {
        SceneManager.LoadScene("Title");
    }
}