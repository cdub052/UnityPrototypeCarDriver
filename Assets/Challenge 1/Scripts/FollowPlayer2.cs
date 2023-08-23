using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 3.5f, 0);

    // Start is called before the first frame update
    void Start()
    {
        // add offset to camera by adding to players location 
        //transform.position = player.transform.position + offset;

    }



    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
