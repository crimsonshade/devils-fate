/* Script Created by Crimsonshade
 * ALl rights reserved Kappa
 */

using System;
using UnityEngine;

public class RemoveLive : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private GameObject[] hearts;
    [SerializeField] private int getDeadMoney;
    [SerializeField] private int loseHearthMoney;

    private short      _state = 0;
    private CoinSystem _coins;
    private bool       _isHearthLose = false;

    #endregion

    private void Awake()
    {
        _coins = FindObjectOfType<CoinSystem>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var monster = other.GetComponent<Monster>();

        if (monster == null) { return; }
        _state++;
        
        if (_state == 1)
        {
            hearts[2].SetActive(false);
            _coins.GetMoney(loseHearthMoney);
        }
        else if (_state == 2)
        {
            hearts[1].SetActive(false);
            _coins.GetMoney(loseHearthMoney);
        }
        else if (_state == 3)
        {
            hearts[0].SetActive(false);
            _coins.GetMoney(getDeadMoney);
            _state = 0;
        }

        if (_state == 0)
        {
            foreach (var t in hearts)
            {
                t.SetActive(true);
            }
        }
    }

    private void Update()
    {
        
    }
}
