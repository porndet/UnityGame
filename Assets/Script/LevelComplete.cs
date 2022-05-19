using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{

    public GameManagement gameManage;

    void OnTriggerEnter() {
        gameManage.CompleteLevel();
    } 
}
