﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructor : MonoBehaviour
{
    [SerializeField] float timeToDestroySpawnedObject = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeToDestroySpawnedObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
