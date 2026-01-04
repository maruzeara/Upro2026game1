using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : singleton<Load>
{
    public float _Load = 0f;

    public IEnumerator LoadScene(int index)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(index);
        asyncLoad.allowSceneActivation = false;

        while(asyncLoad.progress < 0.9f)
        {
            _Load = asyncLoad.progress;
            yield return null;
        }
        asyncLoad.allowSceneActivation = true;

        while (!asyncLoad. isDone )
        {
            _Load = asyncLoad.progress;
            yield return null;
        }
        _Load = 0;
    }
}
