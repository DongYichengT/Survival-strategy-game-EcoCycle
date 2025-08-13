using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHouse : MonoBehaviour
{
    public GameObject housePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10; // 设置一个z值，确保物体在摄像机前方
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Instantiate(housePrefab, worldPosition, Quaternion.identity);
        }
    }
}
