using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSystem : MonoBehaviour
{
    [SerializeField]
    Vector3[] pos;

    public GameObject Object;

    void Start()
    {
        pos = new Vector3[21];
        int x = 0;
        for (int i = 1;i <= 3;i++)
        {
            for(int j = 1;j <= 7;j++)
            {
                pos[x] = new Vector3(-10.5f + 3.0f * (j - 1), 1.5f + 3.5f*(i - 1) , 15.0f + (i - 1));
                x += 1;
            }
        }
        InvokeRepeating("Generate", 1,3);
    }

    void Generate()
    {
        GameObject objects = Instantiate(Object) as GameObject;
        int rnd = Random.Range(0, 21);
        objects.transform.position = pos[rnd];
        Destroy(objects,3.0f);
    }
}
