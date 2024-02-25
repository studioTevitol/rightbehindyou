using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameObject playerObject;
    public Enemy_AI enemy;
    public GameObject enemyPrefab;
    public GameObject Player;
    void Start()
    {
        playerObject = playerMovement.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //Every time an enemy spawns store it in the enemy variable
        //enemy = Instantiate(enemyPrefab).GetComponent<Enemy_AI>();
    }
}
