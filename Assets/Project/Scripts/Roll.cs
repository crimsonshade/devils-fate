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
    [SerializeField] private GameObject blocker;

    private short _number = 1;
    
    public short GetNumber()
    {
        return _number;
    }

    private void Start()
    {
        RollDice();
        blocker.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RollDice();
            blocker.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            blocker.SetActive(true);
        }
    }
    
    private void RollDice()
    {
        _number = (short) Random.Range(1, 21);

        tmp.text = _number.ToString();
    }
}
