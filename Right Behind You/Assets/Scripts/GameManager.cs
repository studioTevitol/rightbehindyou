using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Enemy_AI enemy;
    public GameObject enemyPrefab;
    public Transform entrance;
    public bool keyCollected;
    float timesincelastmoved = 0f;
  
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if (keyCollected|| timesincelastmoved > 5f)
       {
            SpawnEnemy();
            timesincelastmoved = 0f;
       }
        if (player.GetComponent<Rigidbody>().velocity.x==0||player.GetComponent<Rigidbody>().velocity.z==0)
       {
            timesincelastmoved += Time.deltaTime;
       }

        
    }

    void SpawnEnemy ()
    {
        //Every time an enemy spawns store it in the enemy variable
        Destroy(enemy.gameObject);
        enemy = Instantiate(enemyPrefab, entrance).GetComponent<Enemy_AI>();
    }
    
}
