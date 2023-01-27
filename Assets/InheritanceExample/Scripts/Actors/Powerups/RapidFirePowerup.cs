using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFirePowerup : PowerUpBase
{
    [SerializeField] private float powerUpStrength = 0.5f;
    private TurretController _turretController;
    private float _initialTurretCoolDown;
    private void Awake()
    {
        _turretController = FindObjectOfType<TurretController>();
        _initialTurretCoolDown = _turretController.FireCooldown;
    }
    public override void PowerUp()
    {
        HideVisuals();
        _turretController.FireCooldown -= powerUpStrength;
    }

    public override void PowerDown()
    {
        _turretController.FireCooldown = _initialTurretCoolDown;
        DestroyPickup();
    }
}