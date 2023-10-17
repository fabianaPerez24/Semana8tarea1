using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private int life;
    void ChangeLife(int value)
    {
        life += value;
        if(life < 0) 
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            ChangeLife(- collision.gameObject.GetComponent<Damage>().GetDamage);
            life--;
            if(life < 0) 
            {
                Destroy(gameObject);
            }
        }
    }

}
