﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindRotationToSpeed : MonoBehaviour
{
	public ConstantRotate r;
	public HumanSineimator s;

	private void Update ()
	{
		r.speed = s.speed * 10f;
	} 
}