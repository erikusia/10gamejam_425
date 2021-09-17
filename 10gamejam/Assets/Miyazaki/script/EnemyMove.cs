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

    //検知フラグ
    bool OnTarget = false;
    bool TargetOFF = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
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
