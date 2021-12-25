/* Script Created by Crimsonshade
 * ALl rights reserved Kappa
 */

using System;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class Monster : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    
    private Animator _animator;
    private short _number = 1;
    private TextMeshProUGUI _tmp;

    #region GET_SET

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
        _tmp = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Start()
    {
        SpawnMonster();
    }
    
    private void SpawnMonster()
    {
        _number = (short) Random.Range(5, 11);
        _tmp.text = _number.ToString();
        
        _animator.SetTrigger("Down");
    }
}
