using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
   
    [SerializeField, Header("巡回する場所")]
    private Transform[] patrolPoint;

    [SerializeField, Header("移動スピード")]
    float MoveSpeed;

    private int currentPoint = 0;
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
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        if(TargetOFF)
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
       
    }

    //検知関数
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            Debug.Log("検知！");
            TargetOFF = false;
        }
    }
}
