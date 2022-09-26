using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject efectoExplosion;
    public float speed = 10f;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            GameObject efectoRef = Instantiate(efectoExplosion, transform.position, Quaternion.identity);
            Destroy(efectoRef, 1);
            Destroy(gameObject, 0.2f);
        }
        if (collision.gameObject.tag == "Player")
        {
            GameObject efectoRef = Instantiate(efectoExplosion, transform.position, Quaternion.identity);
            Destroy(efectoRef, 1);
            Destroy(gameObject, 0.2f);
        }
    }
}
