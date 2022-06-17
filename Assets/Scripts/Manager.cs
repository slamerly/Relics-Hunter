using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject relic;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
