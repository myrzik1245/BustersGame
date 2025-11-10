using UnityEngine;

public class Mover
{
    private CharacterController _characterController;
    private SpeedStat _speedStat;
    private float _gravity = -0.2f;
    private Vector3 _startPosition;

    public Mover(CharacterController characterController, SpeedStat speedStat)
    {
        _characterController = characterController;
        _speedStat = speedStat;
        _startPosition = _characterController.transform.position;
    }

    public void Move(Vector3 direction)
    {
        Vector3 movement = direction * _speedStat.Speed;

        if (_characterController.isGrounded == false)
            movement.y = _gravity;

        _characterController.Move(movement * Time.deltaTime);
    }

    public void ResetPosition()
    {
        _characterController.enabled = false;
        _characterController.transform.position = _startPosition;
        _characterController.enabled = true;
    }
}
