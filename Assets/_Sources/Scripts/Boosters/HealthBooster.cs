using UnityEngine;

public class HealthBooster : Booster
{
    [SerializeField] private int _healAmount;

    public override void Use(Player player)
    {
        player.Stats.RecoveryHealth(_healAmount);

        Transform playerTransform = player.transform;
        PlayVFX(playerTransform.position, playerTransform);

        Destroy(gameObject);
    }
}
