using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moose : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        speed = 7;
        appropriateFood = "Food_Carrot";
    }

    public override void FoodIsWrong()
    {
        Move(-1.0f, -0.2f);
    }
}
