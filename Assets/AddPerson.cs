using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPerson : MonoBehaviour
{
    public GameObject villagerPrefab;
    public float spawnRadius = 1.0f; // 添加spawnRadius变量

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SpawnVillager();
        }
    }

    void SpawnVillager()
{
    if (villagerPrefab != null)
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; // Make sure the villager is spawned at z = 0

        Vector3 randomOffset = Random.insideUnitCircle * spawnRadius;
        Vector3 spawnPosition = mousePosition + randomOffset;

        Instantiate(villagerPrefab, spawnPosition, Quaternion.identity);
    }
    else
    {
        Debug.LogError("Villager Prefab is not assigned in AddPerson script!");
    }
}
}