using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int pOneScore, pTwoScore, pThreeScore, pFourScore, gameOverScore;
    public BallController ball;
    public GameObject PlayerOne, PlayerTwo, PlayerThree, PlayerFour, panelGameOver;
    public Text winnerPlayer;
    private bool isPlayer1, isPlayer2, isPlayer3, isPlayer4;
    private int playerCount;
    private string winnerStr;

    private void Start()
    {
        playerCount = 4;
        isPlayer1 = true;
        isPlayer2 = true;
        isPlayer3 = true;
        isPlayer4 = true;
    }

    private void Update()
    {
        if(playerCount == 1)
        {
            if(isPlayer1 == true)
            {
                winnerStr = "PLAYER 1 WIN";
                winnerPlayer.text = winnerStr.ToString();
                GameOver();
            }
            if(isPlayer2 == true)
            {
                winnerStr = "PLAYER 2 WIN";
                winnerPlayer.text = winnerStr.ToString();
                GameOver();
            }
            if(isPlayer3 == true)
            {
                winnerStr = "PLAYER 3 WIN";
                winnerPlayer.text = winnerStr.ToString();
                GameOver();
            }
            if(isPlayer4 == true)
            {
                winnerStr = "PLAYER 4 WIN";
                winnerPlayer.text = winnerStr.ToString();
                GameOver();
            }
        }
    }

    public void AddpOneScore(int increment)
    {
        pOneScore += increment;

        if(pOneScore>=gameOverScore)
        {
            playerCount--;
            isPlayer1 = false;
            GameObject TFSWall1 = GameObject.FindWithTag("TFS Wall 1");
            PlayerOne.SetActive(false);
            TFSWall1.GetComponent<MeshRenderer>().enabled = true;
            TFSWall1.GetComponent<BoxCollider>().enabled = true;
        }
    }

    public void AddpTwoScore(int increment)
    {
        pTwoScore += increment;

        if(pTwoScore>=gameOverScore)
        {
            playerCount--;
            isPlayer2 = false;
            GameObject TFSWall2 = GameObject.FindWithTag("TFS Wall 2");
            PlayerTwo.SetActive(false);
            TFSWall2.GetComponent<MeshRenderer>().enabled = true;
            TFSWall2.GetComponent<BoxCollider>().enabled = true;
        }
    }

    public void AddpThreeScore(int increment)
    {
        pThreeScore += increment;

        if(pThreeScore>=gameOverScore)
        {
            playerCount--;
            isPlayer3 = false;
            GameObject TFSWall3 = GameObject.FindWithTag("TFS Wall 3");
            PlayerThree.SetActive(false);
            TFSWall3.GetComponent<MeshRenderer>().enabled = true;
            TFSWall3.GetComponent<BoxCollider>().enabled = true;
        }
    }

    public void AddpFourScore(int increment)
    {
        pFourScore += increment;

        if(pFourScore>=gameOverScore)
        {
            playerCount--;
            isPlayer4 = false;
            GameObject TFSWall4 = GameObject.FindWithTag("TFS Wall 4");
            PlayerFour.SetActive(false);
            TFSWall4.GetComponent<MeshRenderer>().enabled = true;
            TFSWall4.GetComponent<BoxCollider>().enabled = true;
        }
    }

    public void GameOver()
    {
        panelGameOver.SetActive(true);
    }
}
