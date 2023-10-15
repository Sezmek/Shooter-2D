using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform target;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float targetPosX = target.position.x + offset.x;
        if (targetPosX > transform.position.x)
        {
            Vector3 pos = new Vector3(targetPosX, transform.position.y, transform.position.z);
            transform.position = pos;
        }
    }
}
