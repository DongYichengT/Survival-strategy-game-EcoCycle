using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VillagerManager : MonoBehaviour
{
    public GameObject villagerPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            AddVillager();
        }
    }

    void AddVillager()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Instantiate(villagerPrefab, worldPosition, Quaternion.identity);
    }
}