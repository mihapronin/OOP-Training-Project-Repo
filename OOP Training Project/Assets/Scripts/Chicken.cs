using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
        appropriateFood = "Food_Cookie";
    }

    public override void FoodIsWrong()
    {
        Move(1.0f, -0.2f);
    }
}
