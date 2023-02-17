using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public Transform camTransform;
    public GameObject directionLight;
    private Transform lightTransform;
    // public int currentGold = 42;
    // public bool pureOfHeart = true;
    // public bool hasSecretIncantation = false;
    // public string rareItem = "Enchanted Scroll";
    // private int currentAge = 30; 
    // public int addedAge = 1;

    // public float ageGap = 1.75f;
    // public string lastName = "Terwilleger";
    // public bool isAge = true;

    
    // Start is called before the first frame update
    void Start()
    {
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        //directionLight = GameObject.Find("Directional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);


        // //Using Constructors
        //     Character hero = new Character();
        //     //If you use Character hero2 = hero - they will be linked
        //     Character hero2 = new Character();
        //     hero2.name = "Sokka of the Water Tribe";

        //     hero.PrintStatsInfo();
        //     hero2.PrintStatsInfo();
        //     //Wrong way to access reset class, because of the privacy level - hero2.Reset();

        //     Character heroine = new Character("Agatha");
        //     heroine.PrintStatsInfo();

        //     Weapon huntingBow = new Weapon("Hunting Bow", 105);
        //     Weapon warBow = huntingBow;
        //     warBow.name = "War Bow";
        //     warBow.damage = 155;

        //     Paladin knight = new Paladin("Sir Arthur", huntingBow);
        //     knight.PrintStatsInfo();

        //     huntingBow.PrintWeaponStats();
        //     warBow.PrintWeaponStats();
            
        // // DICTIONARY EXAMPLE
        //      Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        //      {
        //          {"Potion", 5},
        //          {"Antidote", 7},
        //          {"Aspirin", 1}
        //      };
        //      //ForEach LOOP
        //      foreach(KeyValuePair<string, int> kvp in itemInventory)
        //      {
        //         Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
        //      }
             // Retrieve Element's Value
        //     int numberOfPotions = itemInventory["Potion"];
        //     // Update Element
        //     itemInventory["Potion"] = 10;
        //     // ADD ELEMENT
        //     itemInventory.Add("Throwing Knife", 3);
        //         // OR
        //         itemInventory["Bandage"] = 5;
        //     // Make sure element exists before changing key!!!
        //         if(itemInventory.ContainsKey("Aspirin"))
        //         {
        //             itemInventory["Aspirin"] = 3;
        //         }
        //     //REMOVE pair
        //     itemInventory.Remove("Antidote");
        //     Debug.LogFormat("Items: {0}", itemInventory.Count);


        // LIST EXAMPLE 1 
            // List<string> questPartyMembers = new List<string>()
            // {"Grim the Barbarian", "Merlin the Wise", "Sterling the Knight"};   
            // //FOREACH loops
            // foreach(string partyMember in questPartyMembers)
            // {
            //     Debug.LogFormat("{0} - Here!", partyMember);
            // }

        // Iteration Loops
                // for (int i = 0; i < questPartyMembers.Count; i++)
                // {
                //     Debug.LogFormat("Index: {0} - {1}", i, questPartyMembers[i]);

                //     if (questPartyMembers[i] == "Merlin the Wise")
                //     {
                //         Debug.Log("Glad you're here Merlin!");
                //     } 
                // }
            // //ADD to end of list
            // questPartyMembers.Add("Craven the Necromancer");
            // //ADD to specific spot
            // questPartyMembers.Insert(1, "Tanis the Thief");
            // //REMOVE from list
            // questPartyMembers.RemoveAt(0);
            //     //OR
            // questPartyMembers.Remove("Grim the Barbarian");
            // Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        // SWITCH fall through example
            // int diceRoll = 7;
            // switch(diceRoll)
            // {
            //     case 7:
            //     case 15:
            //         Debug.Log("Mediocre damage, not bad.");
            //         break;
            //     case 20:
            //         Debug.Log("Critical hit, the creature goes down!");
            //         break;
            //     default:
            //         Debug.Log("You completely missed and fell on your face.");
            //         break;
            // }



        // SWITCH instead of IF/ELSE
            //string characterAction = "Attack!!";
            // switch(characterAction)
            // {
            //     case "Heal":
            //         Debug.Log("Potion sent.");
            //         break;
            //     case "Attack!!":
            //         Debug.Log("To arms!");
            //         break;
            //     default:
            //         Debug.Log("Sheilds up.");
            //         break;
            // }

        //IF/ELSE statement
            // OpenTreasureChamber();
            // if(currentGold > 50)
            // {
            //     Debug.Log("You're rolling in it - Beware of pickpockets.");
            // }
            // else if (currentGold < 15)
            // {
            //     Debug.Log("Not much there to steal.");
            // }
            // else 
            // {
            //     Debug.Log("Your purse is in the sweet spot!");
            // }
            // int characterLevel = 32;
            // int nextSkillLevel = GenerateCharacter("Sokka", characterLevel);
            // Debug.Log(nextSkillLevel);
            // Debug.Log(GenerateCharacter("Katara", characterLevel));
            //ComputeAge();

            //Debug.Log($"A string can have variables like {lastName} inserted directly!");

            //Debug.Log(lastName * ageGap);
    }
    // EXAMPLE of IF/ELSE statments in action
        // public void OpenTreasureChamber()
        // {
        //     if (pureOfHeart && rareItem == "Enchanted Scroll")
        //     {
        //         if(!hasSecretIncantation)
        //         {
        //             Debug.Log("You have the spirit, but not the knowledge.");
        //         }
        //         else
        //         {
        //             Debug.Log("The treasure is yours, worthy Hero!");
        //         }
        //     }
        //     else
        //     {
        //         Debug.Log("Come back when you have what it takes.");
        //     }
        // }
        // public int GenerateCharacter(string name, int level)
        // {
        //     //Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        //     return level + 5;
        // }
        

        // void ComputeAge()
        // {
        //     Debug.Log(currentAge + addedAge);
        // }
}
