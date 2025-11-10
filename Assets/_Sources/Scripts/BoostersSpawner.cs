using UnityEngine;

public class BoostersSpawner : MonoBehaviour
{
    [SerializeField] private Booster[] _boosterPrefabs;
    [SerializeField] private Transform[] _spawnPoints;

    public void SpawnAllPoints()
    {
        foreach (Transform point in _spawnPoints)
        {
            int randomIndex = Random.Range(0, _boosterPrefabs.Length);

            Instantiate(_boosterPrefabs[randomIndex], point.position, Quaternion.identity, point);
        }
    }
}
