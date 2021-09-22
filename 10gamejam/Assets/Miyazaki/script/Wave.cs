using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    [SerializeField] private float countTime;
    [SerializeField] GameObject Wave1;
    [SerializeField] GameObject Wave2;
    [SerializeField] GameObject Wave3;
    [SerializeField] GameTimer gameTimer;
    // Start is called before the first frame update
    void Start()
    {
        countTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        countTime = gameTimer.count;
        //countTime += Time.deltaTime;
        if (countTime > 0)
        {
            Wave1.SetActive(true);
        }
        if (countTime > 1)
        {
            Wave2.SetActive(true);
        }
        if (countTime > 2)
        {
            Wave3.SetActive(true);
            countTime = 0;
        }
    }
}
