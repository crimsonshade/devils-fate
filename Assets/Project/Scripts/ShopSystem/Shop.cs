/* Script Created by Crimsonshade
 * ALl rights reseverd Kappa
 */

using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class Shop : MonoBehaviour
{
    [Header("Scripatble Object")]
    [SerializeField] private ShopSO item;
    [Header("ShopComponents")]
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI buttonText;
    [Header("Settings")]
    [SerializeField] private Button button;
    [SerializeField] private bool notInteractable = false;

    private void Start()
    {
        image.sprite = item.GetImage();
        text.text = item.GetTitle();
        buttonText.text = item.GetPrice();

        if (notInteractable)
        {
            button.interactable = false;
        }
    }
}
