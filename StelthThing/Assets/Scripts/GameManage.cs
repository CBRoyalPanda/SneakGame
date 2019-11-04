using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    public GameObject image;

    public GameObject startButton;

    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have started the game!");

        Destroy(image.gameObject);
        Destroy(startButton.gameObject);
    }
}
