using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColliderSystem : MonoBehaviour
{
    [SerializeField]
	private  AudioClip sound2;
	AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent <AudioSource> ();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "objects")
        {
            audioSource.PlayOneShot(sound2);
            Debug.Log("当たった");
            GameManager.instance.AddScore(1);
            //Destroy(other.gameObject);
            Destroy(this.gameObject,0.5f);
        }
    }
}
