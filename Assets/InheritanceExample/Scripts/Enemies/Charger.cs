using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    [SerializeField] private float _moveSpeedMultiplier = 2;
    protected override void OnHit()
    {
        MoveSpeed *= _moveSpeedMultiplier;
    }

}
