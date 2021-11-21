using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;
    public int maxHealth;

    private float _health;
    private int _score = 0;

    private string HealthDisplay => $"health: {_health}";
    private string ScoreDisplay  => $"coins: {_score}";

    public void AddScore(int value)
    {
        _score += value;
        scoreText.text = ScoreDisplay;
    }
    

    // Start is called before the first frame update
    void Start()
    {
        _health = maxHealth;
        healthText.text = HealthDisplay;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amnt)
    {
        _health -= amnt;
        healthText.text = HealthDisplay;
    }
}
