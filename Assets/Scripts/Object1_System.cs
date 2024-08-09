using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(-24,5,-5);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            Debug.Log("当たった");
            float rnd_y = Random.Range(1, 9);
            float rnd_z = Random.Range(-20, 5);
            this.transform.position = new Vector3(-24,rnd_y,rnd_z);
        }
    }

}
