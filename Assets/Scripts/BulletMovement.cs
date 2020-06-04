using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    private float movementSpeed = 10f;

    private void Start()
    {
        Destroy(gameObject, 1f);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
    }

}
