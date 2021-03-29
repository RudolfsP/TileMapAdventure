using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour {

    [SerializeField] float waitTime = 2.5f;
    [SerializeField] float levelExitSlowMoFactor = 0.2f;

    private void OnTriggerEnter2D(Collider2D otherCollider) {
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene() {

        Time.timeScale = levelExitSlowMoFactor;
        //yield with a delay
        yield return new WaitForSecondsRealtime(waitTime);
        Time.timeScale = 1f;

        //load next scene
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
