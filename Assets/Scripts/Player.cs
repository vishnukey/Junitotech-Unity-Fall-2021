using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public int maxHealth;

    private float _health;
    private int _coins;

    public delegate void HealthEvent(float newHealth);
    public delegate void CoinsEvent(int newCoins);

    public HealthEvent OnHealthChanged;
    public CoinsEvent OnCoinsChanged;

    // Start is called before the first frame update
    void Start()
    {
        _health = maxHealth;
        healthText.text = $"health: {_health}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amnt)
    {
        _health -= amnt;
        OnHealthChanged?.Invoke(_health);
        healthText.text = $"health: {_health}";
    }

    public void AddCoin()
    {
        _coins += 1;
        OnCoinsChanged(_coins);
    }
}
