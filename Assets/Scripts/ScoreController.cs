using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scorePOne, scorePTwo, scorePThree, scorePFour;
    public ScoreManager manager;
    
    private void Update()
    {
        scorePOne.text = manager.pOneScore.ToString();
        scorePTwo.text = manager.pTwoScore.ToString();
        scorePThree.text = manager.pThreeScore.ToString();
        scorePFour.text = manager.pFourScore.ToString();
    }
}
