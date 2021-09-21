using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    List<GameObject> Onotes = new List<GameObject>();

    float count;
    int a;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        

        
        if(count>=3)
        {
            int a=Random.Range(0, 4);
            notes.Add(Instantiate(Onotes[a]));
            Debug.Log(notes.Count);
            count = 0;
        }

        if(notes.Count!=0)
        {
            DetectKeys();
            for (int i = 0; i < notes.Count; i++)
            {
                Vector3 pos = notes[i].gameObject.transform.position;
                pos.x += 0.07f;
                notes[i].gameObject.transform.position = pos;
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
                    Debug.Log("いいね！");
                }
     
            }
            else Debug.Log("ミス！");
            Destroy(notes[0]);
            notes.RemoveAt(0);
        }

        if (Input.GetButtonDown("Button_B"))
        {
            GameObject Fnotes = notes[0].gameObject;
            if (Fnotes.name == "B(Clone)")
            {
                Vector3 FNpos = Fnotes.transform.position;
                if (FNpos.x <= 0.5 && FNpos.x >= -0.5)
                {
                    Debug.Log("いいね！");
                }

            }
            else Debug.Log("ミス！");
            Destroy(notes[0]);
            notes.RemoveAt(0);
        }

        if (Input.GetButtonDown("Button_X"))
        {
            GameObject Fnotes = notes[0].gameObject;
            if (Fnotes.name == "X(Clone)")
            {
                Vector3 FNpos = Fnotes.transform.position;
                if (FNpos.x <= 0.5 && FNpos.x >= -0.5)
                {
                    Debug.Log("いいね！");
                }

            }
            else Debug.Log("ミス！");
            Destroy(notes[0]);
            notes.RemoveAt(0);
        }

        if (Input.GetButtonDown("Button_Y"))
        {
            GameObject Fnotes = notes[0].gameObject;
            if (Fnotes.name == "Y(Clone)")
            {
                Vector3 FNpos = Fnotes.transform.position;
                if (FNpos.x <= 0.5 && FNpos.x >= -0.5)
                {
                    Debug.Log("いいね！");
                }

            }
            else Debug.Log("ミス！");
            Destroy(notes[0]);
            notes.RemoveAt(0);
        }
    }
}
