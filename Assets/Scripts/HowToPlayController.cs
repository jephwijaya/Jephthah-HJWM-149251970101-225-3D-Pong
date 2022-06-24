using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayController : MonoBehaviour
{
    public GameObject[] panel;
    public GameObject rightButton, leftButton;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        leftButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(index >=2)
        {
            index = 2;
        }

        if(index < 0)
        {
            index = 0;
        }

        if(index == 0)
        {
            panel[0].gameObject.SetActive(true);
        }
    }

    public void RightButton()
    {
        index += 1;
        
        for(int i = 0; i<panel.Length; i++)
        {
            panel[i].gameObject.SetActive(false);
            panel[index].gameObject.SetActive(true);
            rightButton.gameObject.SetActive(false);
            leftButton.gameObject.SetActive(true);
        }

        Debug.Log("Index : " + index);
    }

    public void LeftButton()
    {
        index -= 1;
        
        for(int i = 0; i<panel.Length; i++)
        {
            panel[i].gameObject.SetActive(false);
            panel[index].gameObject.SetActive(true);
            rightButton.gameObject.SetActive(true);
            leftButton.gameObject.SetActive(false);
        }

        Debug.Log("Index : " + index);
    }

    public void BackToMainMenu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
