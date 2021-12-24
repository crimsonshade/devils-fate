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
        ResetState();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnMonster();
            _animator.SetBool("Down", true);
            ResetState();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {

        }
    }
    
    private void SpawnMonster()
    {
        _number = (short) Random.Range(1, 21);
        _tmp.text = _number.ToString();
    }

    private void ResetState()
    {
        _animator.SetBool("Left", false);
        _animator.SetBool("Right", false);
    }
}
