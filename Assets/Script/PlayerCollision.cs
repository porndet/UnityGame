using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMove movement;
    void OnCollisionEnter(Collision collisioninfo) {
        if(collisioninfo.collider.tag == "Collisionbox"){
            movement.enabled = false;
            FindObjectOfType<GameManagement>().EndGame();
        }
    }
}
