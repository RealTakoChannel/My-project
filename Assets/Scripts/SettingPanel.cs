using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SettingPanel : MonoBehaviour
{

    public GameObject menu;
    private void Update()
    {
        
    }
    public void activeMenu()
    {
        menu.SetActive(true);

    }
    public void deActiveMenu()
    {
        menu.SetActive(false);

    }
}
