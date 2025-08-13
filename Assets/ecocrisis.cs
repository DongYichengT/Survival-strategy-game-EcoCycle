using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ecocrisis : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadDemoMap()
    {
        SceneManager.LoadScene("DemoMap");
    }
}
