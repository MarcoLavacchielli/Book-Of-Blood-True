using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject MenuTutorial;
    public GameObject MenuCredits;


        private void Awake()
    {
        ActivarMainMenu();
    }
    public void ActivarMainMenu()
    {
        MainMenu.SetActive(true);
        MenuCredits.SetActive(false);
        MenuTutorial.SetActive(false);
    }
    public void ActivarTutorial()
    {
        MainMenu.SetActive(false);
        MenuCredits.SetActive(false);
        MenuTutorial.SetActive(true);
    }
    public void ActivarCredits()
    {
        MainMenu.SetActive(false);
        MenuCredits.SetActive(true);
        MenuTutorial.SetActive(false);
    }
}
