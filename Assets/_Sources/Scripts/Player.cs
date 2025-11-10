using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField, Min(1)] private int _maxHealth;
    [SerializeField, Min(1)] private int _startHealth;
    [SerializeField, Min(0)] private float _maxSpeed;
    [SerializeField, Min(0)] private float _startSpeed;
    [SerializeField] private MovementByInput _playerMovement;
    [SerializeField] private BoosterCollector _boosterCollector;

    private KeyboardInput _input;
    private Stats _stats;
    private HealthStat _healthStat;
    private SpeedStat _speedStat;

    public int Health => _stats.Health;
    public float Speed => _stats.Speed;
    public Stats Stats => _stats;

    public void Initialize(KeyboardInput input)
    {
        _input = input;

        _healthStat = new HealthStat(_maxHealth, _startHealth);
        _speedStat = new SpeedStat(_maxSpeed, _startSpeed);
        _stats = new Stats(_healthStat, _speedStat);

        _playerMovement.Initialize(_input, _speedStat);
    }

    private void Update()
    {
        if (_input.IsBusterActivated)
            _boosterCollector.UseCurrentBooster(this);
    }
}
