using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform aim;
    [SerializeField] ParticleSystem ps;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        ps.Play();
        GameObject bullet = Instantiate(prefab, aim.position, transform.rotation);
    }
}
