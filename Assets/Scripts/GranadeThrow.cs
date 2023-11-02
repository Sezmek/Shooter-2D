using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THrowGranade : MonoBehaviour
{
    [SerializeField] GameObject GranadePrefab;
    [SerializeField] Vector2 Dir;
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Throw();
        }
    }
    void Throw()
    {
        GameObject granade = Instantiate(GranadePrefab, transform.position, Quaternion.identity);
        granade.GetComponent<Rigidbody2D>().AddForce(Dir, ForceMode2D.Impulse);
    }
}
