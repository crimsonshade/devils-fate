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

    private CoinSystem _coin;
    private SpriteRenderer _monster;

    private void Awake()
    {
        _coin = FindObjectOfType<CoinSystem>();
        _monster = FindObjectOfType<Monster>().GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        image.sprite = item.GetImage();
        text.text = item.GetTitle();
        buttonText.text = item.GetPrice().ToString();

        if (notInteractable)
        {
            button.interactable = false;
        }
    }

    public void B_BuyItem()
    {
        if (_coin.GetMoney() >= item.GetPrice())
        {
            _coin.RemoveMoney(item.GetPrice());
            button.interactable = false;
        }
    }

    public void B_ChangeSprite()
    {
        _monster.sprite = item.GetImage();
    }
}
