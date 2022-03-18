using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        appropriateFood = "Food_Steak";
    }

    public override void FoodIsWrong()
    {
        Move(0f, -1.0f);
    }
}
