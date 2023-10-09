using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginReset : MonoBehaviour
{
    public void Reset(Vector3 resetDirection)
    {
        gameObject.transform.position -= resetDirection;
    }
}
