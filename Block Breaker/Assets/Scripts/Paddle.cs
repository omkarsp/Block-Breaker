using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float screenWidthUnits = 16f;
    [SerializeField] float paddleLeftLimit;
    [SerializeField] float paddleRightLimit;

    //cached reference

    GameStatus TheGameStatus;
    Ball TheBall;

    // Use this for initialization
    void Start ()
    {
        TheGameStatus = FindObjectOfType<GameStatus>();
        TheBall = FindObjectOfType<Ball>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 paddlePos= new Vector2(transform.position.x,transform.position.y);
        paddlePos.x = Mathf.Clamp(GetXPos(), paddleLeftLimit, paddleRightLimit);
        transform.position = paddlePos;
    }

    private float GetXPos()
    {
        if (TheGameStatus.IsAutoPlayEnabled() == true)
        {
            return TheBall.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthUnits;
        }
    }
}
