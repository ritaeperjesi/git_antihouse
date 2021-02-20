using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTower : MonoBehaviour
{
    public GameObject maci;
    public int width = 10;
    public int height = 4;

    // Start is called before the first frame update
    void Start()
    {
       
        // Instantiate at position (0, 0, 0) and zero rotation.


        for (int y = -5; y < height; ++y)
        {
            for (int x = -10; x < width; ++x)
            {
                Instantiate(maci, new Vector3((x+0.5f), y+1, 0), Quaternion.identity);
            }
        }

        for (int y = -5; y < height; ++y)
        {
            for (int x = -10; x < width; ++x)
            {
                Instantiate(maci, new Vector3((x + 0.5f), y + 1, 14), Quaternion.identity);
            }
        }

     

        /* for (int y = -2; y<height; ++y)
           {
               for (int x = 1; x<width; ++x)
               {
                   Instantiate(maci, new Vector3(-x, y+1, 0), Quaternion.identity);
               }
           } */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
