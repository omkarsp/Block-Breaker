using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour {

    //config params
    [Range(0.1F,10F)][SerializeField] float timeSpeed;
    [SerializeField] int pointsPerBlockDestroyed;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] bool isAutoPlayEnabled;
    //variables
	[SerializeField] int currentScore = 0;
    
    //Awake is called before start
    //To keep the final score from last scene
    
        
        /*private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }*/


    //for initiallization
    public void Start ()
    {
        scoreText.text = currentScore.ToString();
        currentScore = 0;
	}
	
	// Update is called once per frame
	public void Update ()
    {
        Time.timeScale = timeSpeed;
	}

    //Count and dispay the current score
    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }

    //Resets the score at the beginning
    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }
}