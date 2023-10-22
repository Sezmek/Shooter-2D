using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform aim;
    [SerializeField] float RepeatTime = 2;
    [SerializeField] int attackDMG = 1;

    void StartShooting()
    {
        GameObject bullet = Instantiate(prefab, aim.position, transform.rotation);
        bullet.GetComponent<EnemyB>().SetAttack(attackDMG);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            BoxCollider2D box = gameObject.GetComponent<BoxCollider2D>();
            box.enabled = false;
            InvokeRepeating(nameof(StartShooting), 0, RepeatTime);
            EnemyPatrol enemyPatrol = GetComponentInParent<EnemyPatrol>();
            if(enemyPatrol != null)
            {
                enemyPatrol.SetVelocity();
            }
        }
    }
}
