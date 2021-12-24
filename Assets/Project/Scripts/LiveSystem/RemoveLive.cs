/* Script Created by Crimsonshade
 * ALl rights reseverd Kappa
 */

using System;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class RemoveLive : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;

    private short _state = 0;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        var monster = other.GetComponent<Monster>();

        if (monster == null) { return; }
        _state++;
    }

    private void Update()
    {
        if (_state == 1)
        {
            hearts[2].SetActive(false);
        }
        else if (_state == 2)
        {
            hearts[1].SetActive(false);
        }
        else if (_state == 3)
        {
            hearts[0].SetActive(false);
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
}
