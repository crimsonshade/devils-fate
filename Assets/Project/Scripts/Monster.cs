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
        _number = (short) Random.Range(1, 21);
        _tmp.text = _number.ToString();
    }

    private void Update()
    {
        RestartLevel();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger("Down");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            _animator.SetTrigger(_d20.GetNumber() >= _number ? "Left" : "Right");
        }
    }

    private void RestartLevel()
    {
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
