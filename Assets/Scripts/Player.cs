using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public int maxHealth;

    private float _health;
    

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
        healthText.text = $"health: {_health}";
    }
}
