using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public int maxHealth;
    
    private float _health;
    private PlayerInput _input;

    // Start is called before the first frame update
    void Start()
    {
        _health = maxHealth;
        healthText.text = $"health: {_health}";
        _input = GetComponent<PlayerInput>();
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

    public void OnThrow(/*InputValue value*/)
    {
        Debug.Log($"THROW");
    }

    public void OnPunch(/*InputValue value*/)
    {
        Debug.Log($"PUNCH");
    }
}
