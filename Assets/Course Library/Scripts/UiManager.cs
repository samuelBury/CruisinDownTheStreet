using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public Canvas inGameCanva;
    public Canvas gameOverCanva;
    public Canvas menuCanva;
    public TextMeshProUGUI UIMeter;
    public TextMeshProUGUI UIMeterGameOver;


    // Start is called before the first frame update
    void Start()
    {
      
    }
    public void StartGame()
    {
        menuCanva.gameObject.SetActive(false);
        gameOverCanva.gameObject.SetActive(false);
        inGameCanva.gameObject.SetActive(true);
    }
    public void GameOver(string nbKMParcouru)
    {
        menuCanva.gameObject.SetActive(false);
        inGameCanva.gameObject.SetActive(false);
        gameOverCanva.gameObject.SetActive(true);
        UIMeterGameOver.text = nbKMParcouru;

}
    public void Menu()
    {
        inGameCanva.gameObject.SetActive(false);
        gameOverCanva.gameObject.SetActive(false);
        menuCanva.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
