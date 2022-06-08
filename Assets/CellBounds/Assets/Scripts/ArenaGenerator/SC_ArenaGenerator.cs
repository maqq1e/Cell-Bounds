using System.Collections.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ArenaGenerator : MonoBehaviour
{
    public Texture2D tex;

    public List<GameObject> CellTiles = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {        
        int Row = tex.width;
        for (var i = 0; i < Row; i++)
        {
            for (var f = 0; f < Row; f++)
            {
                double PixelColor = Math.Round(tex.GetPixel(i,f)[0], 2);
                Vector3 position = new Vector3(i,0,f);
                
                
                switch (PixelColor)
                {
                    case 1:
                        Instantiate(CellTiles[0], position, Quaternion.identity);
                        break;
                    case 0.95:
                        Instantiate(CellTiles[1], position, Quaternion.identity);
                        break;
                    case 0.9:
                        Instantiate(CellTiles[2], position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                           
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
