using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SenceManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneChange()
    {
        SceneManager.LoadScene("Missions");
    }
    public void HomeChange()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
