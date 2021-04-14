using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CreateMap : MonoBehaviour
{
    [SerializeField] int[,] m_mapData;
    [SerializeField] string m_fileName;
    void Start()
    {

        SpritMapData();
        //inctance.Load(m_fileName);
    }

    void Update()
    {
        
    }
    public void DataMapping()
    {
        MapStates mapStates;
        //switch (mapStates)
        //{
        //    case MapStates.Road:
        //        break;
        //    case MapStates.Wall:
        //        break;
        //    case MapStates.Start:
        //        break;
        //    case MapStates.Goal:
        //        break;
        //}
    }
    public int[,] SpritMapData()
    {
        TextFileCriate instance = new TextFileCriate();
        string text = instance.LoadTextResource("mapData");
        string[] lineText = text.Split('\n');
        m_mapData = new int[lineText.Length, 9];
        for (int i = 0; i < lineText.Length; i++)
        {
            string[] pointText = lineText[i].Split(',');
            for (int j = 0; j < pointText.Length; j++)
            {
                m_mapData[i,j] = int.Parse(pointText[j]);
                Debug.Log(m_mapData[i, j]);
            }
        }
        return m_mapData;
    }
    enum MapStates
    {
        Road,
        Wall,
        Start,
        Goal
    }
}
