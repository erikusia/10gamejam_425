using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyMove : MonoBehaviour
{

    [SerializeField, Header("巡回する場所")] private Transform[] patrolPoint;
    [SerializeField, Header("移動スピード")]float MoveSpeed;
    [SerializeField]public GameObject find;
    [SerializeField]private float countTime;
    [SerializeField] public Vector3 velocity;

    private int currentPoint = 0;
    int Heartcount = 0;
    private Rigidbody rd;
    public GameObject player;



    //検知フラグ
    bool OnTarget = false;
    bool TargetOFF = true;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        find.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (OnTarget)
        {

            if (Input.GetButtonDown("Button_A") || Input.GetButtonDown("Button_B") || Input.GetButtonDown("Button_X") || Input.GetButtonDown("Button_Y"))
            {
                Debug.Log("A");
                Heartcount++;
            }
        }
        if (Heartcount > 3)
        {
            SceneManager.LoadScene("End");
        }
        Move();
    }
    private void Move()
    {
        countTime += Time.deltaTime;
      
        if (TargetOFF)
        {
            var vec = patrolPoint[currentPoint].position - transform.position;

            //y軸固定
            vec.y = 0;

            transform.position += vec.normalized * MoveSpeed * Time.deltaTime;

            if (vec.magnitude < 0.1f)
            {
                currentPoint = (currentPoint + 1) % 4;
            }
        }
        if (countTime > 10)
        {
            TargetOFF = false;
        }
        if(!TargetOFF)
        {
            transform.Translate(velocity.x, velocity.y, velocity.z);
            Destroy(this.gameObject, 3.0f);
        }

    }

    //検知関数
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("検知！");
            //find.SetActive(true);
            //TargetOFF = false;
            OnTarget = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Heartcount = 0;
        find.SetActive(false);
    }
}
