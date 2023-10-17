using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{


    [SerializeField]
    public GameObject bulletPrefab;

    private float shootTimer;
    private float shootDelayTime;
    void Update()
    {
        timer();
        Shoot();
    }
  void timer()
    {
        shootTimer+= Time.deltaTime;
    }


    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space) && shootTimer >= shootDelayTime)
        {
            GameObject obj= Instantiate(bulletPrefab);
            obj.transform.position = transform.position;
            shootTimer = 0;
        }
    }
  
   
}
