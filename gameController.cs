using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{

private bool gameOver;
private bool win;

private AudioSource audioSource;

    void Start() {
        
        gameOver = false;
        win = false;
        audioSource = GetComponent<AudioSource>();

    }

    void Update() {

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if(PlayerController.lives <= 0) {
            Debug.Log("Dead");
            gameOver = true;
        }

        if(PlayerController.scoreValue == 4000) {
            SceneManager.LoadScene("Level 2");
            PlayerController.scoreValue = 4500;
        }

        if(PlayerController.scoreValue >= 8500) {
            win = true;
        }


        if(gameOver) {
            SceneManager.LoadScene("Game Over");
            PlayerController.lives = 3;
            PlayerController.scoreValue = 0;
        }

        if(win) {
            SceneManager.LoadScene("Win");
            PlayerController.lives = 3;
            PlayerController.scoreValue = 0;
        }

    }
}
