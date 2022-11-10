using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GSGD1;
using TMPro;

public class HealthUI : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _healthtxt = null;
    private PlayerStats _playerStats = null;

    private void Awake()
    {
        _playerStats = LevelReferences.Instance.PlayerStats;
    }

    private void OnEnable()
    {
        _playerStats.DamageTaken.RemoveListener(UpdateTextField);
        _playerStats.DamageTaken.AddListener(UpdateTextField);
        UpdateTextField();
    }
    private void OnDisable()
    {
        _playerStats.DamageTaken.RemoveListener(UpdateTextField);
    }

    private void UpdateTextField()
    {
        _healthtxt.SetText("Health: " + _playerStats.GetHealth());
    }
}
