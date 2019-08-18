﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Move a GameObject by constant speed over time.
/// </summary>
public class Mover : MonoBehaviour
{
    [Header("Constant Speed")] public Vector3 speed = Vector3.forward;

    // Start is called before the first frame update
    void Start()
    {
        // Do nothing
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime;
    }
}
