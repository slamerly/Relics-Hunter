using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Situtation : MonoBehaviour
{
    [Header("Choice 1")]
    public string choice1;
    public int modifHealth1, modifFood1, modifAlignment1;
    [Header("Choice 2")]
    public string choice2;
    public int modifHealth2, modifFood2, modifAlignment2;
    [Header("Choice Relic")]
    public List<string> choiceRelic;
    public List<int> modifHealthRelic;
    public List<int> modifFoodRelic;
    public List<int> modifAlignmentRelic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
