/* Script Created by Crimsonshade
 * ALl rights reseverd Kappa
 */

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject credits;
    [SerializeField] private GameObject mainMenu;

    private void Start()
    {
        credits.SetActive(false);
        mainMenu.SetActive(true);
    }

    #region MAIN_MENU

    public void _StartGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void _Credits()
    {
        credits.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void _QuitGame()
    {
        Application.Quit();
    }

    public void _BackToMenu()
    {
        credits.SetActive(false);
        mainMenu.SetActive(true);
    }

    #endregion

    #region CREDITS

    public void _Monsters()
    {
        Application.OpenURL("https://kenney.itch.io/creature-mixer");
    }

    public void _Sprites()
    {
        Application.OpenURL("https://pixelfrog-assets.itch.io/kings-and-pigs");
    }

    public void _Font()
    {
        Application.OpenURL("https://emhuo.itch.io/peaberry-pixel-font");
    }

    #endregion
}
