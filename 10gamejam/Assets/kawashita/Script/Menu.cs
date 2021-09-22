using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button pauseButton;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button resumeButton;
   [SerializeField] private Button TitleButton;
    [SerializeField] private Button OnryoButton;
    [SerializeField]
    private GameObject pauseUI;
    [SerializeField]
    private GameObject returnUI;
    [SerializeField]
    private GameObject titleUI;
    [SerializeField]
    private GameObject onryoUI;

    void Start()
    {
        pausePanel.SetActive(false);
        pauseButton.onClick.AddListener(Pause);
        resumeButton.onClick.AddListener(Resume);
        TitleButton.onClick.AddListener(Title);
        OnryoButton.onClick.AddListener(Onryo);
    }

    void Update()
    {
        
    }

    private void Pause()
    {
        Time.timeScale = 0;  // 時間停止
        pausePanel.SetActive(true);
        pauseUI.SetActive(false);
        returnUI.SetActive(true);
        titleUI.SetActive(true);
        onryoUI.SetActive(true);
    }

    private void Resume()
    {
        Time.timeScale = 1;  // 再開
        pausePanel.SetActive(false);
        pauseUI.SetActive(true);
        returnUI.SetActive(false);
        titleUI.SetActive(false);
        onryoUI.SetActive(false);
    }

    private void Title()
    {
        SceneManager.LoadScene("Title");
    }

    private void Onryo()
    {

    }
}
