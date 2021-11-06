using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI coinText;

    // Start is called before the first frame update
    void Start()
    {
        var player = FindObjectOfType<Player>();
        player.OnHealthChanged += OnHealthChanged;
        player.OnCoinsChanged += OnCoinsChanged;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHealthChanged(float newHealth)
    {
        healthText.text = $"Health: {newHealth}";
    }

    public void OnCoinsChanged(int coins)
    {
        coinText.text = $"Coins: {coins}";
    }
}
