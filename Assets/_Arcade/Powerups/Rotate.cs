using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float RotateSpeed;
    void Update()
    {
        transform.Rotate(0f,RotateSpeed*Time.deltaTime,0f,Space.Self);
    }
}
