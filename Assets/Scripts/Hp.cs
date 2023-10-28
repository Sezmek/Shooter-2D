using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{
    [SerializeField] Image HPslider;
    [SerializeField] int MaxHp = 10;
    [SerializeField] ParticleSystem PS;
    int hp;

    private void Start()
    {
        hp = MaxHp;
    }
    public void TakeDamage(int dmg, Vector3 pos)
    {
        hp -= dmg;
        PS.transform.position = pos;
        PS.Play();
        UpdateHP();
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    void UpdateHP()
    {
        if (HPslider != null)
        {
            HPslider.fillAmount = (float)hp / MaxHp;
        }
    }

    public void Heal(int healAmount)
    {
        if(hp + healAmount > 10)
        {
            hp = 10;
        }
        else
        {
            hp += healAmount;
        }
        UpdateHP();
    }
}
