using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Situtation : MonoBehaviour
{
    [Header("Choice 1")]
    public Text button1;
    public string choice1;
    public int modifHealth1, percentHealth1;
    public int modifFood1, percentFood1;
    public int modifAlignment1, percentAlignment1;
    [Header("Choice 2")]
    public Text button2;
    public string choice2;
    public int modifHealth2, percentHealth2;
    public int modifFood2, percentFood2;
    public int modifAlignment2, percentAlignment2;
    [Header("Choice Relic")]
    public Text button3;
    public List<string> choiceRelic;
    public List<int> modifHealthRelic;
    public List<int> percentHealthRelic;
    public List<int> modifFoodRelic;
    public List<int> percentFoodRelic;
    public List<int> modifAlignmentRelic;
    public List<int> percentAlignmentRelic;

    // Start is called before the first frame update
    void Start()
    {
        button1.text = choice1;
        button2.text = choice2;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
