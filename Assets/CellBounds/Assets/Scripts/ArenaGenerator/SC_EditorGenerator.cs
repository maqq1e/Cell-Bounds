using UnityEngine;

public class SC_EditorGenerator : MonoBehaviour
{
    public GameObject CT_Editor;
    public float widthOfArena = 128;
    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < widthOfArena; i++)
        {
            for (var f = 0; f < widthOfArena; f++)
            {
                Vector3 position = new Vector3(i,0,f);
                Instantiate(CT_Editor, position, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
