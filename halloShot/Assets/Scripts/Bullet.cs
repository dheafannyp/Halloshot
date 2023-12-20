using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 2f;

    private void Start()
    {
        // Memusnahkan objek peluru setelah waktu yang ditentukan
        Destroy(gameObject, lifetime);
    }

    private void Update()
    {
        // Bergerak maju sesuai kecepatan
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Memusnahkan peluru jika bertabrakan dengan objek lain (opsional)
        Destroy(gameObject);
    }
}
