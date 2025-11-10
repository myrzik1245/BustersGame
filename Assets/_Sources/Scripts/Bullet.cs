using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Bullet : MonoBehaviour
{
    private CharacterController _characterController;
    private Vector3 _movement;

    private bool _isThrowed = false;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (_isThrowed == false)
            return;

        _characterController.Move(_movement * Time.deltaTime);
    }

    public void Shoot(float speed, Vector3 direction, Transform startTransform)
    {
        SetStartTransform(startTransform);

        _movement = direction * speed;
        _isThrowed = true;
    }

    private void SetStartTransform(Transform startTransform)
    {
        _characterController.enabled = false;

        transform.position = startTransform.position;
        transform.rotation = startTransform.rotation;

        _characterController.enabled = true;
    }
}
