﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour {

    GameObject hpGauge;

	// Use this for initialization
	void Start () {
        this.hpGauge = GameObject.Find("hpGauge");

    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

}
