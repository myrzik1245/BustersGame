using UnityEngine;

public class Mover
{
    private CharacterController _characterController;
    private SpeedStat _speedStat;
    private float _gravity = -0.2f;

    public Mover(CharacterController characterController, SpeedStat speedStat)
    {
        _characterController = characterController;
        _speedStat = speedStat;
    }

    public void Move(Vector3 direction)
    {
        Vector3 movement = direction * _speedStat.Speed;

        if (_characterController.isGrounded == false)
            movement.y = _gravity;

        _characterController.Move(movement * Time.deltaTime);
    }
}
