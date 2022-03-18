using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager item;
    public List<GameObject> Animals;

    void Start()
    {
        item = this;
    }

    public void SpawnAnimal()
    {
        int i = Random.Range(0, 3);
        GameObject theAnimal = DataManager.item.Animals[i];
        theAnimal.SetActive(true);
    }
}
