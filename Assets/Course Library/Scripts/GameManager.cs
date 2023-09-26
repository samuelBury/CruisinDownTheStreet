using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float gameSpeed;
    private float gameSpeedOrigin = 50;
    public bool isGameOn = false;
    public float kmetreParcouru = 0;
    private TimeManager timeManager;
    private UiManager uiManager;
    private SoundManager soundManager;
    private SpawnManager spawnManager;
    
    void Start()
    {
        timeManager = GameObject.Find("TimeManager").GetComponent<TimeManager>();
        uiManager = GameObject.Find("UiManager").GetComponent<UiManager>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        uiManager.Menu();
        soundManager.GameOver();
        
    }

    // Update is called once per frame
    void Update()
    {
        kmetreParcouru = Mathf.Round(gameSpeed * timeManager.GetElapsedTime())/1000;
        uiManager.UIMeter.text = kmetreParcouru.ToString() + " Km";
       
       
    }
    public void GameOver()
    {
        gameSpeed = 0;
        isGameOn = false;
        timeManager.StopTimer();
        uiManager.GameOver(kmetreParcouru.ToString() + " Km");
        soundManager.GameOver();
    }
    public void StartGame()
    {
        gameSpeed = gameSpeedOrigin;
        timeManager.StartTimer();
        uiManager.StartGame();
        isGameOn=true;
        soundManager.startGame();
        
    }
    public void Menu() {
        isGameOn = false;
        uiManager.Menu();
        SceneManager.LoadScene("Prototype 1");
        
    }
    

}
