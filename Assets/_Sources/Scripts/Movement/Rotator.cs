using UnityEngine;

public class Rotator
{
    private float _rotationSpeed;
    private Transform _transform;
    private Quaternion _startRotation;

    public Rotator(Transform transform, float rotationSpeed)
    {
        _transform = transform;
        _rotationSpeed = rotationSpeed;
        _startRotation = _transform.rotation;
    }

    public void Rotate(Vector3 direction)
    {
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        float step = _rotationSpeed * Time.deltaTime;

        _transform.rotation = Quaternion.RotateTowards(_transform.rotation, targetRotation, step);
    }

    public void ResetRotation()
    {
        _transform.rotation = _startRotation;
    }
}
