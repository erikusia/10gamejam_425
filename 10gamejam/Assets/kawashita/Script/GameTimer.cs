using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] Image gauge;
    [SerializeField] float waveTimeOut;
    [SerializeField] float waveTimeTrigger;

    [SerializeField] Text timeText;
    [SerializeField] Text gaugeText;
    public int count = 0; //ウェーブのカウント
    float second; // 秒数

    // Start is called before the first frame update
    void Start()
    {
        gauge.fillAmount = 0f;
        timeText.text = "";
        gaugeText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (second <= waveTimeOut)
        {
            //ウェーブのリピート
            StartWave();
        }
    }

    void StartWave()
    {
       
            // ゲージを毎秒0.125増やす
            //gauge.fillAmount += 0.125f * Time.deltaTime;
            gauge.fillAmount += (1 /waveTimeOut )* Time.deltaTime;

            // 秒数をカウント
            second += Time.deltaTime;

        // ゲージ量を表示
        gaugeText.text = gauge.fillAmount.ToString();

        // 秒数を表示
        timeText.text = second + "秒";

        if (second>=waveTimeOut)
        {
            // ウェーブを生成する
            second = 0;
            waveTimeOut += waveTimeTrigger;
            gauge.fillAmount = 0f;
            count += 1;
        }

        //waveTimeTrigger = Time.time + waveTimeOut;

    }

    //void GenerateWave()
    //{
    //    second = 0;
    //    waveTimeOut += 10;
       
    //}
}
