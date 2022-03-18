using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public static bool AnimalIsOnScene;

    protected float speed;
    protected string appropriateFood;

    private float horzontalInput;
    private float verticalInput;
    private bool controlledByPlayer = true;
    private string foodToEat;


    private void Update()
    {
        horzontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (controlledByPlayer)
        {
            ControlByPlayer();
        }
        else
        {
            ReactOnFood(foodToEat);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            controlledByPlayer = false;
            foodToEat = other.gameObject.name;
        }

        if (other.CompareTag("BadBoundary"))
        {
            gameObject.transform.position = new Vector3(0, 0, -8);
            gameObject.SetActive(false);
            controlledByPlayer = true;
            DataManager.item.SpawnAnimal();
        }
    }

    void ControlByPlayer()
    {
        Move(horzontalInput, verticalInput);
    }

    protected void Move(float horizontalMove, float verticalMove)
    {
        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalMove);
        gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalMove);
    }

    void ReactOnFood(string food_name)
    {
        if (food_name == appropriateFood)
        {
            FoodIsGood();
        }
        else
        {
            FoodIsWrong();
        }
    }

    public virtual void FoodIsGood()
    {
        Move(0.5f, 0.5f);
    }

    public virtual void FoodIsWrong()
    {
        Move(0.0f, -0.5f);
    }
}
