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

    private bool rolled;
    private short _number = 1;

    #region GET_SET

    public short GetNumber()
    {
        return _number;
    }

    public GameObject GetBlocker()
    {
        RollDice();
        return blocker;
    }

    public bool GetRollState()
    {
        return rolled;
    }

    public void SetRollState(bool state)
    {
        rolled = state;
    }

    #endregion
    
    private void Start()
    {
        rolled = false;
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
        if (rolled == false)
        {
            _number = (short) Random.Range(1, 21);
            tmp.text = _number.ToString();
        }
    }
}
