using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : MonoBehaviour
{
    public GameObject player;
    NavMeshAgent agent;
    Collider objcollider;
    public float MaxSight = 20f;
    Collider[] checkForPlayer = new Collider[32];
    public bool SeenByPlayer = false;
    public float radius;

    private void Awake()
    {
        player = FindObjectOfType<PlayerMovement>().gameObject;
        agent = GetComponent<NavMeshAgent>();
        objcollider = GetComponent<Collider>();
        radius = agent.radius;
    }
    void Start()
    {
    

    }

    void Update()
    {
        
        agent.SetDestination(player.transform.position);
        
        int colliderNum = Physics.OverlapCapsuleNonAlloc(new Vector3(transform.position.x, transform.position.y - 0.67f, transform.position.z), new Vector3(transform.position.x, transform.position.y + 0.67f, transform.position.z), radius + 0.5f, checkForPlayer);
        if (colliderNum > 0)
        {
            for (int i = 0; i < colliderNum; i++)
            {
                if (checkForPlayer[i].transform.gameObject.tag=="Player")
                {
                    OnCatchPlayer();
                }
            }
        }
       
    }
    void OnCatchPlayer()
    {
        Debug.Log("Caught!");
    }
}
