using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject relic;
    public Text healthUI;
    public Text foodUI;
    public Text alignmentUI;
    public int health;
    public int maxHealth = 100;
    public int food;
    public int maxFood = 5;
    public int alignment = 0;
    public int maxAlignment = 25;

    private int cptSituation = 0;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        food = maxFood;
        healthUI.text = "Health : " + health;
        foodUI.text = "Food : " + food;
        alignmentUI.text = "Alignment : " + alignment;
    }

    public void SetHealth(int newValue)
    {
        health = newValue;
        healthUI.text = "Health : " + health;
    }

    public void SetFood(int newValue)
    {
        food = newValue;
        foodUI.text = "Food : " + food;
    }

    public void SetAlignment(int newValue)
    {
        alignment = newValue;
        alignmentUI.text = "Alignement : " + alignment;
    }
}
