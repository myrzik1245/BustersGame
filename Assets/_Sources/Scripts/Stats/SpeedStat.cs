using System;
using UnityEngine;

public class SpeedStat
{
    private float _maxSpeed;

    public SpeedStat(float maxSpeed, float startSpeed)
    {
        _maxSpeed = maxSpeed;
        Speed = startSpeed;
    }

    public float Speed {  get; private set; }

    public void ChangeSpeed(float speed)
    {
        if (speed <= 0)
            Debug.LogError($"Change speed <= 0 ({speed})");


        Speed = Math.Clamp(speed, 0, _maxSpeed);
    }
}
