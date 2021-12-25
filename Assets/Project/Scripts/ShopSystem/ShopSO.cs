/* Script Created by Crimsonshade
 * ALl rights reseverd Kappa
 */

using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ShopItem 00", menuName = "ShopItems/Object", order = 1)]
public class ShopSO : ScriptableObject
{
    [SerializeField] private Sprite image;
    [SerializeField] private string title;
    [SerializeField] private int    price;

    public Sprite GetImage() { return image; }
    public string GetTitle() { return title; }
    public string GetPrice() { return price.ToString(); }
}
