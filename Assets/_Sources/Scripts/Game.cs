using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Player _playerMovement;
    [SerializeField] private BoostersSpawner _boostersSpawner;

    private KeyboardInput _keyboardInput = new KeyboardInput();

    private void Start()
    {
        _playerMovement.Initialize(_keyboardInput);
        _boostersSpawner.SpawnAllPoints();
    }
}
