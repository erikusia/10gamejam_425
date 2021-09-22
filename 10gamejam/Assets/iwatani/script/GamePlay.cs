using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    List<GameObject> notes = new List<GameObject>();

    [SerializeField]
    List<GameObject> anotes = new List<GameObject>();

    [SerializeField]
    List<GameObject> Onotes = new List<GameObject>();

    [SerializeField]
    List<GameObject> Anotes = new List<GameObject>();

    [SerializeField]
    Slider hpSlider;

    [SerializeField]
    GameObject Rnotes;
    [SerializeField]
    GameObject ARnotes;

    [SerializeField]
    AudioSource audio;
    [SerializeField]
    AudioClip audioClip;
    [SerializeField]
    GameTimer wavecount;

    float count;
    int a;

    private void Awake()
    {
        if (SoundManager.Instance.playBgm)
        {
            SoundManager.Instance.StopBgm();
        }
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;


        if(Input.GetButton("Button_L"))
        {
            Debug.Log("L押してる");
            if (count >= 3)
            {
                int a = Random.Range(0, 4);
                notes.Add(Instantiate(Onotes[a]));
                anotes.Add(Instantiate(Anotes[a]));
                Debug.Log(notes.Count);
                count = 0;
            }
        }
        else
        {
            if (count >= 3)
            {
                notes.Add(Instantiate(Rnotes));
                anotes.Add(Instantiate(ARnotes));
                count = 0;
            }
        }


        if(notes.Count!=0)
        {
            DetectKeys();
            for (int i = 0; i < notes.Count; i++)
            {
                Vector3 pos = notes[i].gameObject.transform.position;
                Vector3 apos= anotes[i].gameObject.transform.position;
                pos.x += 0.07f;
                apos.x -= 0.07f;
                notes[i].gameObject.transform.position = pos;
                anotes[i].gameObject.transform.position = apos;

                if (notes[i].gameObject.transform.position.x >= 1)
                {
                    Destroy(notes[i]);
                    notes.RemoveAt(i);   
                }

                if(anotes[i].gameObject.transform.position.x <= -1)
                {
                    Destroy(anotes[i]);
                    anotes.RemoveAt(i);
                }
            }
        }
        if (hpSlider.value<=0)
        {
            SceneManager.LoadScene("End");
        }
        if(wavecount.count>2)
        {
            SceneManager.LoadScene("GameCler");
        }
    }

    //ボタン入力
    void DetectKeys()
    {
        if (Input.GetButtonDown("Button_A"))
        {
            GameObject Fnotes = notes[0].gameObject;
            if (Fnotes.name== "A(Clone)")
            {
                Vector3 FNpos = Fnotes.transform.position;
                if (FNpos.x<=0.5&&FNpos.x>=-0.5)
                {
                    audio.PlayOneShot(audioClip);
                    hpSlider.value += 5;
                    Debug.Log("いいね！");
                }
     
            }
            else Debug.Log("ミス！");
            Destroy(notes[0]);
            Destroy(anotes[0]);
            notes.RemoveAt(0);
            anotes.RemoveAt(0);
        }

        if (Input.GetButtonDown("Button_B"))
        {
            GameObject Fnotes = notes[0].gameObject;
            if (Fnotes.name == "B(Clone)")
            {
                Vector3 FNpos = Fnotes.transform.position;
                if (FNpos.x <= 0.5 && FNpos.x >= -0.5)
                {
                    audio.PlayOneShot(audioClip);
                    hpSlider.value += 5;
                    Debug.Log("いいね！");
                }

            }
            else Debug.Log("ミス！");
            Destroy(notes[0]);
            Destroy(anotes[0]);
            notes.RemoveAt(0);
            anotes.RemoveAt(0);
        }

        if (Input.GetButtonDown("Button_X"))
        {
            GameObject Fnotes = notes[0].gameObject;
            if (Fnotes.name == "X(Clone)")
            {
                Vector3 FNpos = Fnotes.transform.position;
                if (FNpos.x <= 0.5 && FNpos.x >= -0.5)
                {
                    audio.PlayOneShot(audioClip);
                    hpSlider.value += 5;
                    Debug.Log("いいね！");
                }

            }
            else Debug.Log("ミス！");
            Destroy(notes[0]);
            Destroy(anotes[0]);
            notes.RemoveAt(0);
            anotes.RemoveAt(0);
        }

        if (Input.GetButtonDown("Button_Y"))
        {
            GameObject Fnotes = notes[0].gameObject;
            if (Fnotes.name == "Y(Clone)")
            {
                Vector3 FNpos = Fnotes.transform.position;
                if (FNpos.x <= 0.5 && FNpos.x >= -0.5)
                {
                    audio.PlayOneShot(audioClip);
                    hpSlider.value += 5;
                    Debug.Log("いいね！");
                }

            }
            else Debug.Log("ミス！");
            Destroy(notes[0]);
            Destroy(anotes[0]);
            notes.RemoveAt(0);
            anotes.RemoveAt(0);
        }

        if (Input.GetButtonDown("Button_R"))
        {
            GameObject Fnotes = notes[0].gameObject;
            if (Fnotes.name == "R(Clone)")
            {
                Vector3 FNpos = Fnotes.transform.position;
                if (FNpos.x <= 0.5 && FNpos.x >= -0.5)
                {
                    hpSlider.value -= 3;
                    Debug.Log("いいね！");
                }

            }
            else Debug.Log("ミス！");
            Destroy(notes[0]);
            Destroy(anotes[0]);
            notes.RemoveAt(0);
            anotes.RemoveAt(0);
        }
    }
}
