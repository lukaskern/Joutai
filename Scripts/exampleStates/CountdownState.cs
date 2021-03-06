﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Joutai;

public class CountdownState : InstructionState
{
    float countDownTimer = 3.0f;

    public override void OnEnable()
    {
        if (use) {
        base.OnEnable();
        }
    }

	void Update()
	{
        countDownTimer -= Time.deltaTime;
        textPane.text = countDownTimer.ToString("f0");

        if (countDownTimer < 0) AdvanceState();
    }
}
