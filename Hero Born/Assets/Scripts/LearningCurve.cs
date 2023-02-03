using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    private int currentAge = 30; 
    public int addedAge = 1;

    public float ageGap = 1.75f;
    public string lastName = "Terwilleger";
    public bool isAge = true;
    // Start is called before the first frame update
    void Start()
    {
        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("Sokka", characterLevel);
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Katara", characterLevel));
        //ComputeAge();

        //Debug.Log($"A string can have variables like {lastName} inserted directly!");

        //Debug.Log(lastName * ageGap);
    }
    public int GenerateCharacter(string name, int level)
    {
        //Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level + 5;
    }

    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }
}
