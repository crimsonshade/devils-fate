/* Script Created by Crimsonshade
 * ALl rights reseverd Kappa
 */

using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SideMenu : MonoBehaviour
{
    public GameObject pageOne;
    public GameObject pageTwo;

    public Button left;
    public Button right;

    private void Start()
    {
        pageOne.SetActive(true);
        pageTwo.SetActive(false);

        right.interactable = true;
        left.interactable = false;
    }

    public void ShowPageTwo()
    {
        pageOne.SetActive(false);
        pageTwo.SetActive(true);

        right.interactable = false;
        left.interactable = true;
    }

    public void ShowPageOne()
    {
        pageOne.SetActive(true);
        pageTwo.SetActive(false);
        
        right.interactable = true;
        left.interactable = false;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level");
    }
}
