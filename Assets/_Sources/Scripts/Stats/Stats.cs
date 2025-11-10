public class Stats
{
    private HealthStat _healthStat;
    private SpeedStat _speedStat;

    public Stats(HealthStat health, SpeedStat speed)
    {
        _healthStat = health;
        _speedStat = speed;
    }

    public int Health => _healthStat.Health;
    public float Speed => _speedStat.Speed;

    public void RecoveryHealth(int amount)
    {
        _healthStat.Heal(amount);
    }

    public void ChangeSpeed(float speed)
    {
        _speedStat.ChangeSpeed(speed);
    }
}
