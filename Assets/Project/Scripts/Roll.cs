/* Script Created by Crimsonshade
 * ALl rights reserved Kappa
 */

using System;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class Roll : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tmp;
    [SerializeField] private GameObject blocker;

    private bool _rolled = true;
    private short _number = 1;

    #region GET_SET

    public short GetNumber()
    {
        return _number;
    }

    public GameObject GetBlocker()
    {
        return blocker;
    }

    public void RollD20()
    {
        RollDice();
    }

    public bool GetRollState()
    {
        return _rolled;
    }

    public void SetRollState(bool state)
    {
        _rolled = state;
    }

    #endregion
    
    private void Start()
    {
        _rolled = false;
        blocker.SetActive(true);
    }

    private void RollDice()
    {
        if (_rolled == false)
        {
            _number = (short) Random.Range(1, 21);
            tmp.text = _number.ToString();
            _rolled = true;
        }
    }
}
