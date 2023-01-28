using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFirePowerup : PowerUpBase
{
    [SerializeField] private float powerUpStrength = 2f;
    private TurretController _turretController;

    private void Awake()
    {
        _turretController = FindObjectOfType<TurretController>();

    }
    public override void PowerUp()
    {

        _turretController.FireCooldown /= powerUpStrength;
    }

    public override void PowerDown()
    {
        _turretController.FireCooldown = _turretController.InitialFireCooldown;

    }
}