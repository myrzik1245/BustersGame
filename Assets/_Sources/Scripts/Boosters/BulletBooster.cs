using UnityEngine;

public class BulletBooster : Booster
{
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField, Min(0)] private float _timeToDestroy;

    public override void Use(Player player)
    {
        Bullet bullet = Instantiate(_bulletPrefab);
        bullet.Shoot(_bulletSpeed, player.transform.forward, transform);

        Transform bulletTransform = bullet.transform;
        PlayVFX(bulletTransform.position, bulletTransform);

        Destroy(bullet.gameObject, _timeToDestroy);
        Destroy(gameObject);
    }
}
