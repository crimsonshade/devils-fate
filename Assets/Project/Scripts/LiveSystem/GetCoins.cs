/* Script Created by Crimsonshade
 * ALl rights reseverd Kappa
 */

using System;
using TMPro;
using UnityEngine;

public class GetCoins : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _tmp;
    
    private int _money = 0;
    
    private void Start()
    {
        _money = 100;
        _tmp.text = _money.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var monster = other.GetComponent<Monster>();
        if (monster == null) return;
        
        _money += 20;
        _tmp.text = _money.ToString();
    }
}
