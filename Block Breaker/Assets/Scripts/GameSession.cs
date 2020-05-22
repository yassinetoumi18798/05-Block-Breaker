using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour {

    // config params
    public static float gameSpeed = 0.6f;
    [SerializeField] int pointsPerBlockDestroyed = 83;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] bool isAutoPlayEnabled;
    public static float timeS=1;
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    // state variables
    [SerializeField] int currentScore = 0;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        GameObject.Find("Panel").SetActive(false);
        scoreText.text = currentScore.ToString();    
    }

    // Update is called once per frame
    void Update () {
        if (timeS == 1)
        {
            Time.timeScale = gameSpeed;
        }
        else
        {
            Time.timeScale = timeS;
        }
        
        
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }

    public void getTimeScale()
    {
        
        if (GameIsPaused) {
            timeS = 1f;
            GameIsPaused = false;

            GameObject.Find("Panel").SetActive(true);


        }
        else
        {
            timeS = 0f;
            GameIsPaused = true;

            GameObject.Find("Panel").SetActive(false);


        }




    }

}
