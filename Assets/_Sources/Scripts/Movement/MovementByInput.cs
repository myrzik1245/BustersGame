using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovementByInput : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField, Range(0, 1)] private float _inputThreshold;

    private KeyboardInput _input;
    private Mover _mover;
    private Rotator _rotator;

    public void Initialize(KeyboardInput input, SpeedStat speedStat)
    {
        _input = input;
        _mover = new Mover(GetComponent<CharacterController>(), speedStat);
        _rotator = new Rotator(transform, _rotationSpeed);
    }

    private void Update()
    {
        if (CanMove())
            Move();
    }

    private bool CanMove()
    {
        if (_input.Movement.magnitude < _inputThreshold)
            return false;

        return true;
    }

    private void Move()
    {
        Vector3 direction = _input.Movement.normalized;

        _mover.Move(direction);
        _rotator.Rotate(direction);
    }
}
