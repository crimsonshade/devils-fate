/* Script Created by Crimsonshade
 * ALl rights reseverd Kappa
 */

using System;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class Roll : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tmp;

    private short _number = 1;
    
    private short GetNumber()
    {
        return _number;
    }

    private void Start()
    {
        RollDice();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RollDice();
        }
    }
    
    private void RollDice()
    {
        _number = (short) Random.Range(1, 21);

        tmp.text = _number.ToString();
    }
}
