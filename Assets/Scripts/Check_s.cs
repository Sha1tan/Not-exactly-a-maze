using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_s : MonoBehaviour
{
    private bool _ok = false;
    public GameObject bridge;

    private void Update()
    {
        var _script = bridge.GetComponent<BridgeInter>();
        _script.ok_1 = _ok;
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "silver_cube")
            _ok = true;
    }
}
