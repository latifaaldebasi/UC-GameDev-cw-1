using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string heroName = " latifa ";
    int heroAge = 21;
    float heroHeight = 154.5f;
    string heroSuperPower = "Super Speedy";

    string villainName = "LTF";
    float vililanHeight = 189.5f;
    int villainAge = 30;
    string villainSuperPower = " Super super Speedy";
  
   



    // Start is called before the first frame update
    void Start()
{
    int ageDifference = villainAge - heroAge;
      print (heroName);
      print (heroAge);
      print (heroHeight);
      print (heroSuperPower);

      print (villainName);
      print (vililanHeight);
      print (villainAge);
      print (villainSuperPower);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
