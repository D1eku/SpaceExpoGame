using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    // Start is called before the first frame update
    public Boolean tieneVida = false;
    public float moveSpeed = 10f;
    public GameObject municion;
    public GameObject efectoExplosion;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);

        if (Input.GetKey("space"))
        {
            Instantiate(municion, new Vector2(transform.position.x, transform.position.y+0.2f), Quaternion.identity);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject efectoRef = Instantiate(efectoExplosion, transform.position, Quaternion.identity);
            Destroy(efectoRef, 1);
            Destroy(gameObject, 0.5f);
        }
    }

}
