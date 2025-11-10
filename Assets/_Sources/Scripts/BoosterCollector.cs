using UnityEngine;

public class BoosterCollector : MonoBehaviour
{
    [SerializeField] private Transform _raisedBoosterPosition;
    private Booster _currentBooster;

    private bool IsEmpty => _currentBooster == null;

    private void OnTriggerEnter(Collider other)
    {
        if (IsEmpty == false)
            return;

        if (other.TryGetComponent(out Booster booster))
        {
            _currentBooster = booster;
            _currentBooster.Pickup(_raisedBoosterPosition);
        }
    }

    public void UseCurrentBooster(Player player)
    {
        if (IsEmpty)
        {
            Debug.Log("You don't have booster");
            return;
        }

        _currentBooster.Use(player);
        _currentBooster = null;
    }
}
