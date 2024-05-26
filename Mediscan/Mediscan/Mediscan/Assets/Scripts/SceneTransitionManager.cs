// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class SceneTransitionManager : MonoBehaviour
// {
//     public FadeScreen fadeScreen;
//     public static SceneTransitionManager singleton;

//     private void Awake()
//     {
//         if (singleton && singleton != this)
//             Destroy(singleton);

//         singleton = this;
//     }

//     public void GoToScene(int sceneIndex)
//     {
//         StartCoroutine(GoToSceneRoutine(sceneIndex));
//     }

//     IEnumerator GoToSceneRoutine(int sceneIndex)
//     {
//         fadeScreen.FadeOut();
//         yield return new WaitForSeconds(fadeScreen.fadeDuration);

//         //Launch the new scene
//         SceneManager.LoadScene(sceneIndex);
//     }

//     public void GoToSceneAsync(int sceneIndex)
//     {
//         StartCoroutine(GoToSceneAsyncRoutine(sceneIndex));
//     }

//     IEnumerator GoToSceneAsyncRoutine(int sceneIndex)
//     {
//         fadeScreen.FadeOut();
//         //Launch the new scene
//         AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
//         operation.allowSceneActivation = false;

//         float timer = 0;
//         while(timer <= fadeScreen.fadeDuration && !operation.isDone)
//         {
//             timer += Time.deltaTime;
//             yield return null;
//         }

//         operation.allowSceneActivation = true;
//     }
// }



using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; // Added using directive for IEnumerator

public class SceneTransitionManager : MonoBehaviour
{
    public FadeScreen fadeScreen;
    private static SceneTransitionManager instance;

    private void Awake()
{
    // Ensure there's only one instance of SceneTransitionManager
    if (instance == null)
    {
        // Set this instance as the singleton
        instance = this;

        // Make this GameObject persistent across scene loads
        DontDestroyOnLoad(this.gameObject); // Modified line
    }
    else
    {
        // If another instance exists, destroy this one
        Destroy(gameObject);
        return;
    }
}


    public static SceneTransitionManager Instance
    {
        get
        {
            // Return the singleton instance
            return instance;
        }
    }

    public void GoToScene(int sceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(sceneIndex));
    }

    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);
        SceneManager.LoadScene(sceneIndex);
    }

    public void GoToSceneAsync(int sceneIndex)
    {
        StartCoroutine(GoToSceneAsyncRoutine(sceneIndex));
    }

    IEnumerator GoToSceneAsyncRoutine(int sceneIndex)
    {
        fadeScreen.FadeOut();
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        operation.allowSceneActivation = false;

        float timer = 0;
        while (timer <= fadeScreen.fadeDuration && !operation.isDone)
        {
            timer += Time.deltaTime;
            yield return null;
        }

        operation.allowSceneActivation = true;
    }
}
