using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EcoHealthDisplay : MonoBehaviour
{
    public Text ecoHealthText;

    

   void Start()
    {
        UpdateEcoHealthDisplay(0, 0, 0); // 初始生态健康度为0
        
        GameObject[] forests = GameObject.FindGameObjectsWithTag("tree");
        float forestCount = forests.Length;

        GameObject[] villagers = GameObject.FindGameObjectsWithTag("villager");
        float villagerCount = villagers.Length;

        GameObject[] buildings = GameObject.FindGameObjectsWithTag("house");
        float buildingCount = buildings.Length;

        UpdateEcoHealthDisplay(forestCount, villagerCount, buildingCount);

    }

    public void UpdateEcoHealthDisplay(float forestCount, float villagerCount, float buildingCount)
    {
        

        float ecoHealth = (forestCount * 0.4f) - (villagerCount * 30f )* 0.6f+ buildingCount * 0.6f;
        ecoHealthText.text = "生态健康度: " + ecoHealth.ToString();
    }
    public void UpdateEcoHealth()
    {
        GameObject[] forests = GameObject.FindGameObjectsWithTag("tree");
        float forestCount = forests.Length;

        GameObject[] villagers = GameObject.FindGameObjectsWithTag("villager");
        float villagerCount = villagers.Length;

        GameObject[] buildings = GameObject.FindGameObjectsWithTag("house");
        float buildingCount = buildings.Length;

        float ecoHealth = (forestCount * 0.4f) + ((villagerCount * 30f / buildingCount) * 0.6f);
        ecoHealthText.text = "生态健康度: " + ecoHealth.ToString();
    }
}