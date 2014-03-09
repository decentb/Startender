﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectSpawner : MonoBehaviour {

    // Each prefab that is attached to this array will be instantiated at the beginning of the scene
    // NOTE: This array should not contain the "Player" object
    // That object needs to have more sophisticated generation
    public Transform[] prefabs;
    
    // Use this for initialization
	void Start ()
    {
        foreach (Transform prefab in prefabs)
        {
            Transform clone = Instantiate(prefab) as Transform;
            clone.name = prefab.name;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
	
    }
}
