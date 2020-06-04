using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject shootingPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, shootingPoint.transform.position, Quaternion.identity);
        }
        
    }
}
