using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instance;
    public GameObject gameOverPanel;
    public Text scoretext;
    int score = 0;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        obsyaclespawner.instance.gameover = true;
        StopScrolling();
        gameOverPanel.SetActive(true);
    }
    void StopScrolling()
    {
        BackGroundScroll[] scrlobjects = FindObjectsOfType<BackGroundScroll>();
        foreach (BackGroundScroll t in scrlobjects)
        {
            t.scroll = false;
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("game2");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Incrementscore()
    {
        score++;
        scoretext.text = score.ToString();
    }
}
