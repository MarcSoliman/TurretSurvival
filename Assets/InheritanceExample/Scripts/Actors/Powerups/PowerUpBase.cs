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


    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            StartCoroutine("PowerUpTimer");
        }
    }

    IEnumerator PowerUpTimer()
    {
        HideVisuals();
        PowerUp();
        yield return new WaitForSeconds(PowerupDuration);
        PowerDown();
        Destroy(gameObject);

    }

}
