using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftUp : MonoBehaviour
{
    public bool isPlaced = false;
    public GameObject player;
    
    void Update()
    {
        if (isPlaced)
            MoveUp();
        else
            MoveDown();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            isPlaced = true;
        }
        else
        if (other.gameObject.tag == "Player" && isPlaced == true)
        {
            isPlaced = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isPlaced = false;
    }

    void MoveUp()
    {
        if (transform.position.y < 50)
        {
            player.transform.position += new Vector3(0, 0.1f, 0);
            transform.position += new Vector3(0, 0.1f, 0);            
        }
    }

    void MoveDown()
    {
        if(transform.position.y > 0.5)
            transform.position -= new Vector3(0, 0.1f, 0);
    }
}
