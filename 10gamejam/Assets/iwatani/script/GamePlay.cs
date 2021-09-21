﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject A;

    [SerializeField]
    GameObject B;

    [SerializeField]
    GameObject X;

    [SerializeField]
    GameObject Y;

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


    float count;
    int a;
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
    }
}