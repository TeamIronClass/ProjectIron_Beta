using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

    /// OnGUI is called for rendering and handling GUI events.
    /// This function can be called multiple times per frame (one call per event).
    /// </summary>
    void OnGUI () {
        if (GUI.Button (new Rect (0, 83, 450, 100), "Build")) {
            SceneManager.LoadScene ("Fort Mill World Scale AR", LoadSceneMode.Additive);
        }
    }
};