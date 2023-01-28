using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    [SerializeField] private float _moveSpeedMultiplier = 2;
    [SerializeField] private GameObject _rapidFirePowerup;


    protected override void OnHit()
    {
        MoveSpeed *= _moveSpeedMultiplier;
    }

    public override void Kill()
    {
        _rapidFirePowerup.SetActive(true);
        Instantiate(_rapidFirePowerup, transform.position, Quaternion.identity);
        base.Kill();
    }
}
