using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : MonoBehaviour
{
    NavMeshAgent agent;
    Collider objcollider;
    public float MaxSight = 20f;
    RaycastHit[] hits = new RaycastHit[32];
    Collider[] checkForPlayer = new Collider[32];
    public Transform playerTransform;
    public bool SeenByPlayer = false;
    public float radius;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        objcollider = GetComponent<Collider>();
        radius = agent.radius;
    }

    void Update()
    {
        /*int hitNum = Physics.BoxCastNonAlloc(collider.bounds.center, transform.localScale / 2, transform.forward, hits);
        if (hitNum > 0)
        {
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].transform.gameObject.tag=="Player")
                {
                    agent.SetDestination(hits[i].transform.position);
                }
            }
        }
        */
        agent.SetDestination(playerTransform.position);
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
