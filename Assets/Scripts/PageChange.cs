using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageChange : MonoBehaviour
{
    public void GoNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void GoHome()
    {
        SceneManager.LoadScene(0);
    }
    public void GoPage1()
    {
        SceneManager.LoadScene(1);
    }
    public void GoPage2()
    {
        SceneManager.LoadScene(2);
    }
    public void GoPage3()
    {
        SceneManager.LoadScene(3);
    }
    public void GoPage4()
    {
        SceneManager.LoadScene(4);
    }
    public void GoCredits()
    {
        SceneManager.LoadScene(5);
    }
}
