using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddObject : MonoBehaviour
{
    public GameObject treePrefab;
    public GameObject housePrefab;
    public Text ecoHealthText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10; // 设置一个z值，确保物体在摄像机前方
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            GameObject newTree=Instantiate(treePrefab, worldPosition, Quaternion.identity);

            
            newTree.tag = "tree"; // 将新创建的树木GameObject打上"tree"标签

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10; // 设置一个z值，确保物体在摄像机前方
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
           GameObject newHouse= Instantiate(housePrefab, worldPosition, Quaternion.identity);
           newHouse.tag = "house";
            UpdateEcoHealth();
        }
    }

     void UpdateEcoHealth()
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