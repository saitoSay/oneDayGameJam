using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO; //ファイル入出力のための名前空間

public class TextFileCriate : MonoBehaviour
{
    /// <summary>ファイルの名前</summary>
    [SerializeField] string m_fileName = null;
    /// <summary></summary>
    //[SerializeField] string m_data = null;

    public void CreateFIle()
    {
        string filePath = GetFilePath(m_fileName);
        Debug.Log($"ファイル '{filePath}'を作ります");
        File.Create(filePath);
    }
    /// <summary>
    /// ファイルパスを返す関数
    /// </summary>
    /// <returns>ファイルパス</returns>
    public string GetFilePath(string fileName)
    {
        //三項演算子は名前が空欄の時のエラーを防ぐために使用した
        string filePath = Application.persistentDataPath + "\\Assets" + "\\" + (fileName == " " ? Application.productName : fileName) + ".txt";
        return filePath;
    }
    public void Load(string fileName)
    {
        try
        {
            using (var reader = new StreamReader(GetFilePath(fileName)))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Debug.Log(line);
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Debug.Log(ex);
            throw;
        }
    }

    public string LoadTextResource(string txtResourceName)
    {
        TextAsset text = Resources.Load<TextAsset>(txtResourceName);
        return text.text;
    }
}
