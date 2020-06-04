using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    private static ObjectPool objectPoolInstance;

    private Queue<GameObject> objectPool;
    [SerializeField] private int poolSize = 10;
    [SerializeField] private GameObject poolItemPrefab;

    private void Awake()
    {
        if (objectPoolInstance == null)
        {
            objectPoolInstance = this;
        }
        else if(objectPoolInstance != this)
        {
            Debug.Log("More than one pool instance");
        }

        InitPool(poolSize);

    }

    private void InitPool(int size)
    {
        objectPool = new Queue<GameObject>();
        for (int i = 0; i < size; i++)
        {
            GameObject poolItem = Instantiate(poolItemPrefab);
            poolItem.SetActive(false);
            objectPool.Enqueue(poolItem);
        }
    }

    public GameObject GetObjectFromPool()
    {
        GameObject poolItem = objectPool.Dequeue();
        poolItem.SetActive(true);

        return poolItem;
    }

    public GameObject SetObjectTransform(GameObject go, Vector3 position, Quaternion rotation)
    {
        go.transform.position = position;
        go.transform.rotation = rotation;

        return go;
    }

}
