using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerPostion;
    public Vector3 offset;
    void Update()
    {
        transform.position = playerPostion.position + offset;
    }
}
