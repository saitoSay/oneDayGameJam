using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// シーンロードスクリプト
/// </summary>
public class SceneLoader : MonoBehaviour
{
    /// <summary>シーンの名前</summary>
    [SerializeField] string scenename = "";
    
    /// <summary>
    /// シーンを変える
    /// </summary>
    /// <param name="scenename">変えたいシーン名</param>
    public void ChangeScene()
    {
        SceneManager.LoadScene(scenename);
    }
    public void CoolTime(float time)
    {
        Invoke("ChangeScene", time);
    }
}