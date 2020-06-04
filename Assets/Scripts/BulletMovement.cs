using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    private float movementSpeed = 10f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        ObjectPool.objectPoolInstance.ReturnObjectToPool(gameObject);
    }

}
