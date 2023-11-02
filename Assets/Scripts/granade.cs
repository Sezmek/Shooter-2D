using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granade : MonoBehaviour
{
    [SerializeField] GameObject expPrefab;
    [SerializeField] GameObject Granade;
    [SerializeField] int GranadeDMG = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        GetComponent<Rigidbody2D>().gravityScale = 0;
        Granade.SetActive(false);
        expPrefab.SetActive(true);
        Destroy(gameObject, 1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      Hp hp =  collision.GetComponent<Hp>();
       if (hp != null )
        {
            hp.TakeDamage(GranadeDMG, collision.transform.position);
        }
    }
}
