using UnityEngine;

public class SpeedBooster : Booster
{
    [SerializeField] private float _speed;

    public override void Use(Player player)
    {
        player.Stats.ChangeSpeed(_speed);

        Transform playerTransform = player.transform;
        PlayVFX(playerTransform.position, playerTransform);

        Destroy(gameObject);
    }
}
