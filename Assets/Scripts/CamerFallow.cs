using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFallow : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    private Vector3 offset;

    private void Start()
    {
        offset = target.position - transform.position;
    }
    private void FixedUpdate()
    {
        transform.position = target.position - offset;
    }
}
