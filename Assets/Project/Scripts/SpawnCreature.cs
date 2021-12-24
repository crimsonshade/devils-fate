using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnCreature : MonoBehaviour
{
	[SerializeField] private GameObject[] creatures;

	private void Start()
	{
		MakeCreature();
	}

	private void MakeCreature()
	{
		Instantiate(creatures[Random.Range(0, creatures.Length)]);
	}
}
