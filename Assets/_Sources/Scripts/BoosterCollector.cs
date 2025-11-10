using UnityEngine;

public class BoosterCollector : MonoBehaviour
{
    [SerializeField] private Transform _raisedBoosterPosition;
    private Booster _currentBooster;

    private bool _isEmpty => _currentBooster == null;

    private void OnTriggerEnter(Collider other)
    {
        if (_isEmpty == false)
            return;

        if (other.TryGetComponent(out Booster booster))
        {
            _currentBooster = booster;
            _currentBooster.Pickup(_raisedBoosterPosition);
        }
    }

    public void UseCurrentBooster(Player player)
    {
        if (_isEmpty)
        {
            Debug.Log("You don't have booster");
            return;
        }

        _currentBooster.Use(player);
        _currentBooster = null;
    }
}
