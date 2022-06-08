using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CT_Editor : MonoBehaviour
{

    public List<GameObject> CellTiles = new List<GameObject>();

    void Start()
    {
        Instantiate(CellTiles[0], transform.position, Quaternion.identity);
        
    }

}
