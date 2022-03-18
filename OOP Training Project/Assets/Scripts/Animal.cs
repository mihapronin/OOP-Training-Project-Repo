using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public static bool AnimalIsOnScene;
    public float speed;
    private float horzontalInput;
    private float verticalInput;
    private bool controlledByPlayer = true;

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
            FoodIsBad();
        }
    }

    void ControlByPlayer()
    {
        Move(horzontalInput, verticalInput);
    }

    public void Move(float horizontalMove, float verticalMove)
    {
        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalMove);
        gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalMove);
    }

    public virtual void FoodIsGood()
    {

    }

    public virtual void FoodIsBad()
    {
        Move(0.5f, 0.5f);
    }
}
