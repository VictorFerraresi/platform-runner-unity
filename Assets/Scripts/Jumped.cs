﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

[Serializable] 
public class Jumped {
	public long timeStamp;
	public Cactus nearestCactus;
	public Vector2 distanceToNearestCactus;
	public Vector2 velocity;
	public float height;
}
