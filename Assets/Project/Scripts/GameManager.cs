/* Script Created by Crimsonshade
 * ALl rights reseverd Kappa
 */

using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] monster;
    [SerializeField] private Transform spawnPoint;

    private void Awake()
    {
        transform.position = spawnPoint.transform.position;
    }

    private void Start()
    {
        Instantiate(monster[Random.Range(0, monster.Length)]);
    }
}
