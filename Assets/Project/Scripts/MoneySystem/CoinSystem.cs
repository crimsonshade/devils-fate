/* Script Created by Crimsonshade
 * ALl rights reseverd Kappa
 */

using System;
using TMPro;
using UnityEngine;

public class CoinSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _tmp;
    
    private int _money = 0;

    #region GET_SET

    public int GetMoney()
    {
        return _money;
    }

    public void RemoveMoney(int newMoney)
    {
        _money -= newMoney;
        ChangeMoneyText();
    }

    public void GetMoney(int newMoney)
    {
        _money += newMoney;
        ChangeMoneyText();
    }
    
    public void ChangeMoneyText()
    {
        _tmp.text = _money.ToString();
    }

    #endregion
    
    private void Start()
    {
        _money = 100;
        _tmp.text = _money.ToString();
    }
}
