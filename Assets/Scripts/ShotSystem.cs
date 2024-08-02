using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ShotSystem : MonoBehaviour {
 
    // bullet prefab
    public GameObject bullet;
 
    // 弾丸発射点
    public Transform muzzle;
 
    // 弾丸の速度
    public float speed = 1000;
 
    [SerializeField]
	private  AudioClip sound1;
	AudioSource audioSource;
	void Start () {
		audioSource = GetComponent <AudioSource> ();
	}
	
	void Update () {
        // 左クリックが押されたとき
        if (Input.GetMouseButtonDown(0)){
            
            // 弾丸の複製
            GameObject bullets = Instantiate(bullet) as GameObject;
 
            Vector3 force;
 
            force = this.gameObject.transform.forward * speed;
 
            // Rigidbodyに力を加えて発射
            bullets.GetComponent<Rigidbody>().AddForce(force);
 
            // 弾丸の位置を調整
            bullets.transform.position = muzzle.position;

            audioSource.PlayOneShot(sound1);

            Destroy(bullets,5.0f);
        }
		
	}
}