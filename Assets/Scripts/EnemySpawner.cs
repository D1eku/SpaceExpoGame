using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyObject;
    public float tiempoEntreSpawn = 2;
    public bool spawnEnemy;
    private float tiempoAuxiliar;


    // Start is called before the first frame update
    void Start()
    {
        tiempoAuxiliar = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tiempoAuxiliar += Time.deltaTime;

        if(tiempoAuxiliar>= tiempoEntreSpawn)
        {
            if (spawnEnemy)
            {
                float randomNumber = Random.Range(-9f, 9f);
                Instantiate(enemyObject, new Vector2(randomNumber, transform.position.y), Quaternion.identity);
            }

            tiempoAuxiliar = 0;
        }

        
    }
}
