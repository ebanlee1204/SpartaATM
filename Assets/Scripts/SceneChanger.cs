using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string depositScene;
    public string withdrawScene;
    public string mainScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToMain()
    {
        SceneManager.LoadScene(mainScene);
    }

    public void ToDeposit()
    {
        SceneManager.LoadScene(depositScene);
    }

    public void ToWithdraw()
    {
        SceneManager.LoadScene(withdrawScene);
    }
}
