using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Tambahkan ini untuk menggunakan SceneManager
//labu benar
public class PumpSoal : MonoBehaviour, IDamageable
{
    public float health;

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            // Jika kesehatan habis, panggil metode untuk membuka scene lain
            OpenNextScene();

            // Hancurkan objek (opsional, tergantung pada kebutuhan Anda)
            Destroy(gameObject);
        }
    }

    private void OpenNextScene()
    {
        // Ganti "NamaSceneTujuan" dengan nama scene yang ingin Anda buka
        SceneManager.LoadScene("Quiziz");
    }
}