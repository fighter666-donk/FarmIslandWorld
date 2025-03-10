using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UILogin : MonoBehaviour
{
    public Button buttonPlay;
    public Button buttonExit;
    public Button buttonSet;
    public Button buttonLoad;
    // Use this for initialization
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickButtonPlay()
    {
        SceneManager.Instance.LoadScene("Test");
    }
    public void OnClickButtonExit()
    {

    }
    public void OnClickButtonSet()
    {
        SceneManager.Instance.OnExitGame();
    }

}


