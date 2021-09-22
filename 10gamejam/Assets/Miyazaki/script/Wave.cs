using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    [SerializeField] private float countTime;
    [SerializeField] GameObject Wave1;
    [SerializeField] GameObject Wave2;
    [SerializeField] GameObject Wave3;
    // Start is called before the first frame update
    void Start()
    {
        countTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        if (countTime > 5)
        {
            Wave1.SetActive(true);
        }
        if (countTime > 20)
        {
            Wave2.SetActive(true);
        }
        if (countTime > 40)
        {
            Wave3.SetActive(true);
            countTime = 0;
        }
    }
}
