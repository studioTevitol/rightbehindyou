using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject Keyprefab;
    public Vector3 center;
    public Vector3 size;
    // Start is called before the first frame update
    void Start()
    {
        SpawnKey();
        SpawnKey();
        SpawnKey();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnKey()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2 , size.x /2),Random.Range(-size.y / 2 , size.y /2),Random.Range(-size.z / 2 , size.z /2));
        Instantiate(Keyprefab, pos, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(center, size);
    }
}
