﻿
using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour {
    public Transform Player;
    public Text scoreText;

	// Update is called once per frame
	void Update () {
        scoreText.text = Player.position.z.ToString("0");
	}
}
