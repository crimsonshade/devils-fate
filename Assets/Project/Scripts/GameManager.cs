/* Script Created by Crimsonshade
 * ALl rights reseverd Kappa
 */

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button nextMonster;
    [SerializeField] private float seconds = 0.2f;
    
    private Roll _d20;
    private Monster _monster;

    private void Awake()
    {
        _d20 = FindObjectOfType<Roll>();
        _monster = FindObjectOfType<Monster>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void RevealButton()
    {
        _d20.GetBlocker().SetActive(false);
        _d20.SetRollState(true);
        nextMonster.interactable = true;

        StartCoroutine(MonsterState(seconds));
        StopCoroutine(MonsterState(seconds));
    }

    private IEnumerator MonsterState(float time)
    {
        yield return new WaitForSeconds(time);
        
        if (_d20.GetNumber() >= _monster.GetNumber())
        {
            _monster.GetAnimator().SetBool("Left", true);
        }
        else
        {
            _monster.GetAnimator().SetBool("Right", true);
        }
    }

    public void NextMonster()
    {
        
    }
}
