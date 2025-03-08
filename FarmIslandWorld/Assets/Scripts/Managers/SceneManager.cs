using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SceneManager : MonoBehaviour
{
    UnityAction<float> onProgress = null;
    private static SceneManager instance;
    public static SceneManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SceneManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject("SceneManager");
                    instance = obj.AddComponent<SceneManager>();
                    DontDestroyOnLoad(obj);
                }
            }
            return instance;
        }
    }

    public void LoadScene(string name)
    {
        StartCoroutine(LoadLevel(name));
    }

    IEnumerator LoadLevel(string name)
    {
        Debug.LogFormat("LoadLevel: {0}", name);
        AsyncOperation async = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(name);
        async.allowSceneActivation = true;
        async.completed += LevelLoadCompleted;
        while (!async.isDone)
        {
            if (onProgress != null)
                onProgress(async.progress);
            yield return null;
        }
    }

    private void LevelLoadCompleted(AsyncOperation obj)
    {
        if (onProgress != null)
            onProgress(1f);
        Debug.Log("LevelLoadCompleted:" + obj.progress);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // 退出游戏
    public void OnExitGame()
    {
        // 在编辑器中停止播放
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // 在构建的游戏中使用Application.Quit()
        Application.Quit();
#endif
    }
    //public string sceneName; // 场景名称
    //public int sceneIndex;   // 场景索引

    // 切换到指定名称的场景
    //public void SwitchToSceneByName()
    //{
    //    if (!string.IsNullOrEmpty(sceneName))
    //    {
    //        SceneManager.Instance.LoadScene(sceneName);
    //    }
    //    else
    //    {
    //        Debug.LogError("场景名称为空！");
    //    }
    //}

}
