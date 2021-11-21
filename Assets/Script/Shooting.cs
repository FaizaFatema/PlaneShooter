using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject PlayerBullet;
    public Transform SpawnPoint1;
    public Transform SpawnPoint2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(PlayerBullet, SpawnPoint1.position, Quaternion.identity);
            Instantiate(PlayerBullet, SpawnPoint2.position, Quaternion.identity);
        }
    }
}
