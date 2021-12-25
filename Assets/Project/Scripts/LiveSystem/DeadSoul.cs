/* Script Created by Crimsonshade
 * ALl rights reserved Kappa
 */

using System;
using UnityEngine;

public class DeadSoul : MonoBehaviour
{
    [SerializeField] private int loseMoney;
    
    private CoinSystem _coins;

    private void Awake()
    {
        _coins = FindObjectOfType<CoinSystem>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var monster = other.GetComponent<Monster>();
        if (monster == null) { return; }
        
        _coins.RemoveMoney(loseMoney);
    }
}
