using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーンロードスクリプト
/// </summary>
public class SceneLoader : MonoBehaviour
{
    [SerializeField] string scenename = "";

    /// <summary>
    /// シーンを変える
    /// </summary>
    /// <param name="scenename">変えたいシーン名</param>
    public void ChangeScene()
    {
        SceneManager.LoadScene(scenename);
    }
}