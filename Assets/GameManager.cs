using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static bool isPlaying = true;
    public static float hiz = 4f;

    public GameObject score_text;

    public GameObject pointer;
    public GameObject gameOver;
    public GameObject Pause_btn;
    public GameObject reload;
    public bird bird;
    public PipeObstacle pipes;
    public spawner Spawner;
    




    public void Play()
    {
        
        pointer.SetActive(false);
        gameOver.SetActive(false);
        Pause_btn.SetActive(false);
        bird.enabled = true;
        reload.SetActive(false);


        Time.timeScale = 1f;

        PipeObstacle[] pipes = FindObjectsOfType<PipeObstacle>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

      
    }

    public void Replay()
    {
        Play();

        
        bird.enabled = true;
        bird.transform.position = new Vector3(-7.39f, -0.13f, 0f);
        bird.score = 0f;
        bird.score_text.text = bird.score.ToString();
        


    }

   public void Pause()
    {
        Time.timeScale = 0f;
        pointer.SetActive(true);
        gameOver.SetActive(false);
        bird.enabled = false;

        

    }

    public void Awake()
    {

        Pause();
        
        bird.enabled = false;
        pointer.SetActive(true);
        gameOver.SetActive(false);
        reload.SetActive(false);
        Pause_btn.SetActive(false);
    }


    public void GameOver()
    {
        gameOver.SetActive(true);
        pointer.SetActive(false);

        Time.timeScale = 0f;
        reload.SetActive(true);

        

    }

    



}
