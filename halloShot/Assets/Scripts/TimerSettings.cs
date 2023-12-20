using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerSettings : MonoBehaviour
{
    public TMP_Text textTimer;
    public float Waktu = 100; //01:30

    public bool gameAktif = true;
    public GameObject CanvasKalah;
    
    void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);// 01
        int Detik = Mathf.FloorToInt(Waktu % 60);// 30
        textTimer.text = Menit.ToString("00") + ":" + Detik.ToString("00");
    }

    float s;

    private void Update()
    {
        if (gameAktif)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                s = 0;
            }
        }

        if (gameAktif && Waktu <=0)
        {
            Debug.Log("Game Kalah");
            CanvasKalah.SetActive(true);
            gameAktif = false;
        }
        

        SetText();
    }
}
