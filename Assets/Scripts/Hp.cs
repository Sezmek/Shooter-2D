using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{
    [SerializeField] Image HPslider;
    [SerializeField] int MaxHp = 10;
    int hp;

    private void Start()
    {
        hp = MaxHp;
    }
    public void TakeDamage(int dmg)
    {
        hp -= dmg;
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
}
