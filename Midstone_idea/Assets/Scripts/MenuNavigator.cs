using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigator : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject controls;
    public GameObject IngameUi;
    public GameObject Player;
    public GameObject IceUsystem;
    public GameObject FireUsystem;
    void Start()
    {
        IceUsystem.SetActive(false);
        FireUsystem.SetActive(false);
    }



    public void enterMainMenu()
    {
        MainMenu.SetActive(true);
        IngameUi.SetActive(false);
        Time.timeScale = 0;
    }
    public void exitMainMenu()
    {
        MainMenu.SetActive(false);
        IngameUi.SetActive(true);
        Time.timeScale = 1;
        Player.GetComponent<Player>().Paused = false;
    }
    public void entercontrols()
    {
        controls.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void exitcontrols()
    {
        controls.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void entericeU()
    {
        IceUsystem.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void exiticeU()
    {
        IceUsystem.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void enterfireU()
    {
        FireUsystem.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void exitfireU()
    {
        FireUsystem.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void endgame()
    {

        Debug.Log("gameover");
        Application.Quit();
    }

    







}
