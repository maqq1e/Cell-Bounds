using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ArenaGenerator : MonoBehaviour
{
    public Texture2D tex;
    public GameObject CT_Ground;
    public GameObject CT_Tree;
    public GameObject CT_Water;

    // Start is called before the first frame update
    void Start()
    {
        Color Black = new Color(0,0,0);
        Color Red = new Color(1,0,0);
        Color Green = new Color(0,1,0);
        Color Blue = new Color(0,0,1);
        
        int Row = tex.width;
        for (var i = 0; i < Row; i++)
        {
            for (var f = 0; f < Row; f++)
            {
                Color PixelColor = tex.GetPixel(i,f);
                Vector3 position = new Vector3(i,0,f);
                
                if(PixelColor == Red)
                {
                    Debug.Log(1);
                    Instantiate(CT_Ground, position, Quaternion.identity);
                }
                else if (PixelColor == Green)
                {
                    Debug.Log(2);
                    Instantiate(CT_Tree, position, Quaternion.identity);
                }
                else if (PixelColor == Blue) {
                    Debug.Log(3);
                    Instantiate(CT_Water, position, Quaternion.identity);
                }
                else {
                    Debug.Log(4);
                }
               
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
