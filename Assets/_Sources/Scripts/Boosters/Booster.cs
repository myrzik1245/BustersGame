using UnityEngine;

public abstract class Booster : MonoBehaviour
{
    [SerializeField] private ParticleSystem _useParticlePrefab;
    [SerializeField] private Vector3 _positionInHands;
    [SerializeField] private Vector3 _rotationInHands;
    [SerializeField] private Vector3 _scaleInHands;

    public abstract void Use(Player player);

    public virtual void Pickup(Transform raisedBoosterPosition)
    {
        transform.SetParent(raisedBoosterPosition);
        transform.localPosition = _positionInHands;
        transform.localEulerAngles = _rotationInHands;
    }

    protected void PlayVFX(Vector3 position, Transform parant = null)
    {
        ParticleSystem useParticles = Instantiate(_useParticlePrefab, position, Quaternion.identity, parant);
        useParticles.Play();
    }
}
