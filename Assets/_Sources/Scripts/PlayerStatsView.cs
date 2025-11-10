using TMPro;
using UnityEngine;

public class PlayerStatsView : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _helathText;
    [SerializeField] private TMP_Text _speedText;


    private void Update()
    {
        _helathText.text = $"Health: {_player.Health}";
        _speedText.text = $"Speed: {_player.Speed}";
    }
}
