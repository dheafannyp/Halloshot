using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class jumplow : MonoBehaviour, IDamageable
{
    public float health;
    public Image jumpScareImage; // Pop-up image
    public float jumpScareDuration = 1f; // Durasi pop-up image

    private bool jumpScareActive = false; // Status pop-up image aktif

    public void Start()
    {
        // Sembunyikan pop-up image di awal permainan
        jumpScareImage.gameObject.SetActive(false);
    }
    
    //low: 
    //medium: 
    //high: hang_pumpkin_03
    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            if (!jumpScareActive)
            {
                // Jika labu belum terkena jump scare, aktifkan jump scare dan hancurkan labu
                Debug.Log("Jump Scare");

                StartCoroutine(ShowJumpScare());
            }
        }
    }

    IEnumerator ShowJumpScare()
    {
        // Aktifkan pop-up image
        jumpScareImage.gameObject.SetActive(true);
        jumpScareActive = true;
        Debug.Log("Jump Scare Coroutine");

        // Tunggu selama durasi tertentu
        yield return new WaitForSeconds(jumpScareDuration);

        // Sembunyikan pop-up image setelah durasi tertentu
        jumpScareImage.gameObject.SetActive(false);
        Debug.Log("Jump Scare Coroutine Debug");

        // Hancurkan objek pumpkin
        DestroyPumpkin();

        // Kembalikan kontrol pop-up image ke false
        jumpScareActive = false;
    }

    void DestroyPumpkin()
    {
        // Hancurkan objek pumpkin
        Destroy(gameObject);
    }
}
