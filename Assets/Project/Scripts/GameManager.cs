/* Script Created by Crimsonshade
 * ALl rights reserved Kappa
 */

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button revealButton;
    [SerializeField] private Button nextMonster;
    [SerializeField] private float seconds = 0.2f;
    
    private Roll _d20;
    private Monster _monster;
    private bool _isAlive;

    public bool GetAliveState()
    {
        return _isAlive;
    }
    
    #region UNITY

    private void Awake()
    {
        _d20 = FindObjectOfType<Roll>();
        _monster = FindObjectOfType<Monster>();
    }

    #endregion

    #region BUTTONS

    public void B_Reveal()
    {
        _d20.GetBlocker().SetActive(false);
        _d20.RollD20();
        _d20.SetRollState(true);
        
        nextMonster.interactable = true;
        revealButton.interactable = false;

        StartCoroutine(MonsterState(seconds));
        StopCoroutine(MonsterState(seconds));
    }
    
    public void B_NextMonster()
    {
        _monster.SpawnNewMonster();
        _d20.GetBlocker().SetActive(true);
        _d20.SetRollState(false);
        
        nextMonster.interactable = false;
        revealButton.interactable = true;
        
        _isAlive = false;
    }

    #endregion

    private IEnumerator MonsterState(float time)
    {
        yield return new WaitForSeconds(time);
        
        if (_d20.GetNumber() < _monster.GetNumber())
        {
            _monster.GetAnimator().SetTrigger("Left");
            _isAlive = true;
        }
        else
        {
            _monster.GetAnimator().SetTrigger("Right");
        }
    }
}
