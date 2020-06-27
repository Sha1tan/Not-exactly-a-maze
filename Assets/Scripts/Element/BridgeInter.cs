using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeInter : MonoBehaviour
{
    public bool ok_1 = true, ok_2 = true;
    public GameObject[] prism = new GameObject[12];

    private void Start()
    {
        
    }

    void Update()
    {
        MovePrism();
    }    

    void MovePrism()
    {
        if (ok_1 == true && ok_2 == true && prism[0].transform.position.y > 0)
        {
            for(int i = 0; i <= 11; i++)
            prism[i].transform.position -= new Vector3(0, 0.1f, 0);            

        }
    }
}
