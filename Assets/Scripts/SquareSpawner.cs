using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SquareSpawner : MonoBehaviour
{
    //can probably spawn ~35 boxes before they begin disappearing
    public GameObject square;
    public GameObject spawner;
    public Transform spawnParent;

    // Object Pooling tutorial - Unity YT
    public int poolAmount = 40;
    List<GameObject> squares;

    private void Start()
    {
        squares = new List<GameObject>();
        for(int i = 0; i < poolAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(square, spawnParent);
            obj.SetActive(false);
            squares.Add(obj);
        }
    }

    private void Update()
    {
        Gamepad gpad = Gamepad.current;
        if (gpad == null)
        {
            return;
        }

        if(gpad.buttonNorth.wasPressedThisFrame)
        {
            OnSpawnButton();
        }
    }
    public void OnSpawnButton()
    {
        //Instantiate(square, spawner.transform.position, spawner.transform.rotation);
        for (int i = 0; i < squares.Count; i++)
        {
            if(!squares[i].activeInHierarchy)
            {
                squares[i].transform.position = transform.position;
                squares[i].transform.rotation = transform.rotation;
                squares[i].SetActive(true);
                break;
            }
        }
    }
    
}
