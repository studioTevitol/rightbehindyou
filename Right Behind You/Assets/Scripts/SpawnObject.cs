using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject Keyprefab;
    public Vector3 center;
    public Vector3 size;
    Mesh mesh;
    public Transform mazecorner1;
    public Transform mazecorner2;
    // Start is called before the first frame update
    void Start()
    {
        SpawnKey();
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] walls = Physics.OverlapSphere(transform.position, size.x);
        if (walls.Length > 0)
        {
            for (int i = 0; i < walls.Length; i++)
            {
                if (walls[i].gameObject.tag=="Wall")
                {
                    transform.position = new Vector3(transform.position.x + 0.25f, transform.position.y, transform.position.z);
                }
            }
        }
    }

    public void SpawnKey()
    {
        Vector3 pos = center + new Vector3(Random.Range(mazecorner1.position.x , mazecorner2.position.x),Random.Range(mazecorner1.position.y, mazecorner2.position.y),Random.Range(mazecorner1.position.z, mazecorner2.position.z));
        Keyprefab.transform.localScale.Scale(size);
        Instantiate(Keyprefab, pos, Quaternion.identity);
    }
}
