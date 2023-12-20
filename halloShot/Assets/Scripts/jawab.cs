using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class jawab : MonoBehaviour
{
    public GameObject feed_benar, feed_salah;
    public static int skor;

    public TMP_Text GOText;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    public void jawaban(bool jawab)
    {
    if (jawab) {
            feed_benar.SetActive(false);
            feed_benar.SetActive(true);
            skor = PlayerPrefs.GetInt("skor") + 10;
            PlayerPrefs.SetInt("skor", skor);
            Debug.Log(skor);
        }
    else
        {
            feed_salah.SetActive(false);
            feed_salah.SetActive(true);
        }
        
        gameObject.SetActive(false);
        transform.parent.GetChild (gameObject.transform.GetSiblingIndex () + 1).gameObject.SetActive(true);
    
    }

    // Update is called once per frame
    void Update()
    {
        GOText.text = "" + skor;
    }
}
