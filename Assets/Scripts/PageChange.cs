using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageChange : MonoBehaviour
{
    public void GoNext()    //Go to Next Page
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GoBack()    //Go to Previous Page
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void GoHome()    //Go to Homepage
    {
        SceneManager.LoadScene(0);
    }
    public void GoPage1()   //Go to Page 1
    {
        SceneManager.LoadScene(1);
    }
    public void GoPage2()   //Go to Page 2
    {
        SceneManager.LoadScene(2);
    }
    public void GoPage3()   //Go to Page 3
    {
        SceneManager.LoadScene(3);
    }
    public void GoPage4()   //Go to Page 4
    {
        SceneManager.LoadScene(4);
    }
    public void GoCredits()   //Go to Credits Page
    {
        SceneManager.LoadScene(5);
    }
}
