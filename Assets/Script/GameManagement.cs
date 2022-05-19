using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{   
    public float restartDelay = 1f;
    public GameObject completeUI;

    public void EndGame(){
        Debug.Log("GAME OVER");
        Invoke("Restart", restartDelay);
    }

    public void CompleteLevel(){
        // Debug.Log("LEVEL WON!");
        completeUI.SetActive(true);
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
