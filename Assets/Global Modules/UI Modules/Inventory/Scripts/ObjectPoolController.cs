﻿using UnityEngine;
using System.Collections.Generic;

public class ObjectPoolController : MonoBehaviour
{
    public GameObject pooledObject;
    public int pooledAmount = 2;
    public bool willGrow = true;

    public List<GameObject> pooledObjects;

    void Awake()
    { 
        pooledObjects = new List<GameObject>();

        if (pooledObject == null) {
            return;
        }

        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = Instantiate(pooledObject);
            obj.transform.parent = this.transform;
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (pooledObjects[i] == null)
            {
                GameObject obj = Instantiate(pooledObject);
                obj.transform.parent = this.transform;
                obj.SetActive(false);
                pooledObjects[i] = obj;
                return pooledObjects[i];
            }
            if (!pooledObjects[i].activeInHierarchy)
            {
                pooledObjects[i].SetActive(true);
                return pooledObjects[i];
            }
        }

        if (willGrow)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            pooledObjects.Add(obj);
            obj.transform.parent = this.transform;
            return obj;
        }

        return null;
    }
}

