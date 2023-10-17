using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    public GameObject bulletPrefab;
    void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            GameObject obj= Instantiate(bulletPrefab);
            obj.transform.position = transform.position;  
        }
    }
}
