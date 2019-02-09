using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void gotoBuild()
    {

        SceneManager.LoadScene("collectPsyche", LoadSceneMode.Single);
    }
    public void gotoLearn()
    {
        SceneManager.LoadScene("learnPsyche", LoadSceneMode.Single);

    }
    public void gotoInventory()
    {
        SceneManager.LoadScene("buildPsyche", LoadSceneMode.Single);
    }
    public void goHome()
    {
        SceneManager.LoadScene("homePsyche", LoadSceneMode.Single);
    }

}