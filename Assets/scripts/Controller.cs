using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    /// <summary>mapオブジェクト</summary>
    [SerializeField] GameObject m_map = null;
    /// <summary>入力ベクトル</summary>
    Vector3 m_vector3 = new Vector3();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //マウス左クリックで左回転
        if (Input.GetMouseButton(0))
        {
            m_map.transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime, Space.World);
        }
        //マウス右クリックで右回転
        if (Input.GetMouseButton(1))
        {
            m_map.transform.Rotate(new Vector3(0, 0, -90) * Time.deltaTime, Space.World);
        }
    }
}
