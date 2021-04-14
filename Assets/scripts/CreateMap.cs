using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Tilemaps;

public class CreateMap : MonoBehaviour
{
    [SerializeField] int[,] m_mapData;
    [SerializeField] string m_fileName;
    [SerializeField] Tilemap m_tilemap;
    [SerializeField] Tile m_roadTile;
    [SerializeField] Tile m_wallTIle;
    [SerializeField] GameObject m_startObj;
    [SerializeField] GameObject m_goalObj;
    [SerializeField] GameObject m_player;
    void Start()
    {
        SpritMapData();
        DataMapping();
        //inctance.Load(m_fileName);
    }

    void Update()
    {
        
    }
    public void DataMapping()
    {
        for (int i = 0; i < m_mapData.GetLength(0); i++)
        {
            for (int j = 0; j < m_mapData.GetLength(1); j++)
            {
                Vector3Int tilePosition = new Vector3Int(j - m_mapData.GetLength(0) / 2, -i + m_mapData.GetLength(1) / 2, 0);
                Vector3 objPosition = new Vector3(j - m_mapData.GetLength(0) / 2, -i + m_mapData.GetLength(1) / 2, 0);
                switch (m_mapData[i,j])
                {
                    case (int)MapStates.Road:
                        m_tilemap.SetTile(tilePosition, m_roadTile);
                        break;
                    case (int)MapStates.Wall:
                        m_tilemap.SetTile(tilePosition, m_wallTIle);
                        break;
                    case (int)MapStates.Start:
                        Instantiate(m_startObj, objPosition, Quaternion.identity).transform.parent = m_tilemap.transform;
                        Instantiate(m_player, objPosition, Quaternion.identity).transform.parent = m_tilemap.transform;
                        break;
                    case (int)MapStates.Goal:
                        Instantiate(m_goalObj, objPosition, Quaternion.identity).transform.parent = m_tilemap.transform;
                        break;
                    default:
                        break;
                }
            }
        }
        
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
                //Debug.Log(m_mapData[i, j]);
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
