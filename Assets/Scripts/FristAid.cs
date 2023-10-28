using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FristAid : MonoBehaviour
{
    [SerializeField] int healAmount = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Hp hp = collision.gameObject.GetComponent<Hp>();
        hp.Heal(healAmount);
        Destroy(gameObject);
    }
}
