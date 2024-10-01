
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
	public TextMeshProUGUI healthUI;
	public Player player;
	public Button attackButton;

	private void Start()
	{
		attackButton.onClick.AddListener(ButtonPressed);
	}

	private void Update()
	{
		healthUI.text = player.health.ToString();
	}

	private void ButtonPressed()
	{
		player.Attack();

		StartAttackSequence_Coroutine();
	}

	private IEnumerator StartAttackSequence_Coroutine()
	{
		attackButton.interactable = false;
		yield return new WaitForSeconds(1f);
		attackButton.interactable = true;
	}
}
