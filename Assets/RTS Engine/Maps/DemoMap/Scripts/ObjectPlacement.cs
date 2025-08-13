using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacement : MonoBehaviour
{
    public GameObject treePrefab; // 树木预制体
    public GameObject cityPrefab; // 城市预制体
    public GameObject residentPrefab; // 居民预制体

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 当用户点击鼠标左键
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // 获取鼠标点击位置
            mousePosition.z = 0; // 设置z轴为0，确保物体在地面上

            // 根据用户选择的物体类型实例化预制体
            if (Input.GetKey(KeyCode.Alpha1)) // 按下数字键1放置树木
            {
                Instantiate(treePrefab, mousePosition, Quaternion.identity);
            }
            else if (Input.GetKey(KeyCode.Alpha2)) // 按下数字键2放置城市
            {
                Instantiate(cityPrefab, mousePosition, Quaternion.identity);
            }
            else if (Input.GetKey(KeyCode.Alpha3)) // 按下数字键3放置居民
            {
                Instantiate(residentPrefab, mousePosition, Quaternion.identity);
            }
        }
    }
}