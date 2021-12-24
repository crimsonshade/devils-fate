/* Script Created by Crimsonshade
 * ALl rights reseverd Kappa
 */

using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button nextMonster;
    
    private Roll _d20;

    private void Awake()
    {
        _d20 = FindObjectOfType<Roll>();
    }

    public void RevealButton()
    {
        _d20.GetBlocker().SetActive(false);
        _d20.SetRollState(true);
        nextMonster.interactable = true;
    }

    public void NextMonster()
    {
        
    }
}
