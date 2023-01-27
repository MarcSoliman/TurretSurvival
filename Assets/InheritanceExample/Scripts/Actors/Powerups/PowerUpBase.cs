using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected float PowerupDuration;
    [SerializeField] protected Collider PowerupCollider;
    [SerializeField] protected GameObject powerupVisuals;

    public abstract void PowerUp();
    public abstract void PowerDown();

    protected void HideVisuals()
    {
        PowerupCollider.enabled = false;
        powerupVisuals.SetActive(false);
    }

    protected void DestroyPickup()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            PowerUp();
        }
    }

}
