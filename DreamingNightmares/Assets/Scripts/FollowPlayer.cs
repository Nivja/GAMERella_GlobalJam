using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraPosition;
    void Update()
    {
        transform.position = new Vector3 (player.position.x + cameraPosition.x, 
                                            player.position.y + cameraPosition.y, 
                                            cameraPosition.z);
    }
}
