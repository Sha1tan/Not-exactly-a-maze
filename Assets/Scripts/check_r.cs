using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_r : MonoBehaviour
{
    private bool _ok = false;
    public GameObject bridge;

    private void Update()
    {
        var _script = bridge.GetComponent<BridgeInter>();
        _script.ok_2 = _ok;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "red_cube")
            _ok = true;
    }
}
