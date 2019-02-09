using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControls : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    public void psycheCollect () {

        SceneManager.LoadScene ("psycheCollect");

    }
    public void psycheBuild () {
        SceneManager.LoadScene ("psycheBuild");
    }

    public void psycheLearn () {
        SceneManager.LoadScene ("psycheLearn");
    }
    public void pscyheMap () {
        SceneManager.LoadScene ("psycheMap");
    }
    public void psycheHome()
    {
        SceneManager.LoadScene("psycheHome");
    }
    public void psycheInventory()
    {
        SceneManager.LoadScene("psycheInventory");
    }
    public void psycheSocialMedia()
    {
       SceneManager.LoadScene("psycheSocialMedia");
    }

}