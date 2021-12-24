/* Script Created by Crimsonshade
 * ALl rights reseverd Kappa
 */

using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Monster : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    
    private Animator _animator;
    private short _number = 1;
    private TextMeshProUGUI _tmp;
    private Roll _d20;

    #region GET-SET

    public short GetNumber()
    {
        return _number;
    }

    public Animator GetAnimator()
    {
        return _animator;
    }

    public void SpawnNewMonster()
    {
        SpawnMonster();
    }

    #endregion
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        transform.position = spawnPoint.position;
        _d20 = FindObjectOfType<Roll>();
        _tmp = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Start()
    {
        SpawnMonster();
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnMonster();
            _animator.SetBool("Down", true);
            ResetState();
        }*/
    }
    
    private void SpawnMonster()
    {
        _number = (short) Random.Range(1, 21);
        _tmp.text = _number.ToString();
        _animator.SetTrigger("Down");
    }

    /*private void ResetState()
    {
        _animator.SetBool("Down", false);
        _animator.SetBool("Left", false);
        _animator.SetBool("Right", false);
    }*/
}
