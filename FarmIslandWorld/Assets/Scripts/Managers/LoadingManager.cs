using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Unity.Burst.Intrinsics;
using UnityEngine.Diagnostics;

public class LoadingManager : MonoBehaviour
{
    public GameObject UILoading;
    public GameObject UISetting;
    public GameObject UILogin;
    public GameObject UIFirstGraphic;
    public Slider progressBar;
    public Text progressNumber;
    // Use this for initialization
    //void Start()
    //{
    //    UILoading.SetActive(false);
    //    UILogin.SetActive(true);
    //    //yield return new WaitForSeconds(2.7f);
    //    //UILoading.SetActive(true);
    //    // Fake Loading Simulate
    //    //for (float i = 50; i < 100;)
    //    //{
    //    //    i += Random.Range(0.1f, 1.5f);
    //    //    progressBar.value = i;
    //    //    progressNumber.text = ((int)i).ToString() + "%";
    //    //    yield return new WaitForEndOfFrame();
    //    //}
    //    //UILoading.SetActive(false);
    //    //yield return null;
    //}
    IEnumerator Start()
    {
        UIFirstGraphic.SetActive(true);
        UISetting.SetActive(false);
        UILogin.SetActive(false);
        UILoading.SetActive(false);
        yield return new WaitForSeconds(2.4f);
        UILoading.SetActive(true);
        yield return new WaitForSeconds(2f);
        UIFirstGraphic.SetActive(false);
        // Fake Loading Simulate
        for (float i = 50; i < 100;)
        {
            i += Random.Range(0.1f, 1.5f);
            progressBar.value = i;
            progressNumber.text = ((int)i).ToString() + "%";
            yield return new WaitForEndOfFrame();
        }

        UILoading.SetActive(false);
        UILogin.SetActive(true);
        yield return null;

    }
    // Update is called once per frame
    void Update()
    {

    }
}

