using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour
{
    public GameObject _ico;
    private bool ok = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {                
                ok = true;
            }
        }
    }

    void RotateIco()
    {        
        _ico.transform.Rotate(new Vector3(-1f, 0, 0) * Time.deltaTime);
    }

    private void Update()
    {
        if(ok && _ico.transform.rotation.x > 0)
        {
            RotateIco();
        }
    }
}
