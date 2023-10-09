using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginResetManager : MonoBehaviour
{
    public float ResetAfter = 5;
    public GameObject Ship;

    private void Update()
    {
        Vector3 playerPosition = Ship.transform.position;

        if (playerPosition.magnitude >= ResetAfter)
        {
            OriginReset[] objectList = FindObjectsOfType<OriginReset>();
            foreach (OriginReset obj in objectList)
            {
                obj.Reset(playerPosition);
            }
        }
    }
}
