using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject shootingPoint;

    [SerializeField] private ObjectPool bulletPool;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bullet = bulletPool.GetObjectFromPool();
            bulletPool.SetObjectTransform(bullet, shootingPoint.transform.position, Quaternion.identity);
        } 
    }
}
