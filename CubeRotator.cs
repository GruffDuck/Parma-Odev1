using System;
using System.Collections;
using System.Collections.Generic;
using Pattern;
using UnityEngine;

public class CubeRotator : Singleton<Rotate>
{
    private void Update()
    {
     transform.Rotate(new Vector3(75f * Time.deltaTime,0), Space.World);
    }
}
