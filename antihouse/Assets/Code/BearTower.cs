using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTower : MonoBehaviour
{
    public GameObject pirosmaci;
    public GameObject zoldmaci;
    public GameObject sargamaci;
    public int width = 10;
    public int height = 4;
    public int place_A = 0;
    public int place_B = 10;
    public int place_C = 10;
    public int place_D = -10;

    private GameObject newGummibear;
    public GameObject Torony;

    public GameObject[] maciArray;

    // Start is called before the first frame update
    void Start()
    {
        // maciArray
        maciArray = new GameObject[3];
        maciArray[0] = pirosmaci;
        maciArray[1] = zoldmaci;
        maciArray[2] = sargamaci;

        // Instantiate at position (0, 0, 0) and zero rotation.


        for (int y = 0; y < height; ++y)
        {
            for (int x = 0; x < width; ++x)
            {
                newGummibear = Instantiate(maciArray[UnityEngine.Random.Range(0, 3)], new Vector3((x+1.0f), y, place_A), Quaternion.Euler(new Vector3(90, Random.Range(0, 360), 0)));
                newGummibear.transform.SetParent(Torony.transform);
            }
        }

        for (int y = 0; y < height; ++y)
        {
            for (int x = 0; x < width; ++x)
            {
                newGummibear = Instantiate(maciArray[UnityEngine.Random.Range(0, 3)], new Vector3((x + 1.0f), y , place_B), Quaternion.Euler(new Vector3(90, Random.Range(0, 360), 0)));
                newGummibear.transform.SetParent(Torony.transform);
            }
        }

        for (int y = 0; y < height; ++y)
        {
            for (int x = 0; x < width; ++x)
            {
                newGummibear = Instantiate(maciArray[UnityEngine.Random.Range(0, 3)], new Vector3(place_C, (y  + 5.0f), x + 2), Quaternion.Euler(new Vector3(90, Random.Range(0, 360), 0)));
                newGummibear.transform.SetParent(Torony.transform);
            }
        }

        for (int y = 0; y < height; ++y)
        {
            for (int x = 0; x < width; ++x)
            {
                newGummibear = Instantiate(maciArray[UnityEngine.Random.Range(0, 3)], new Vector3(place_D, (y  + 5.0f), x + 2), Quaternion.Euler(new Vector3(90, Random.Range(0, 360), 0)));
                newGummibear.transform.SetParent(Torony.transform);
            }
        }

        //ceiling


        /*
                for (int y = 2; y < width; ++y)
                {
                    for (int z = -10; z < width; ++z)
                    {
                        newGummibear = Instantiate(maciArray[UnityEngine.Random.Range(0, 3)], new Vector3(y + 1, 800,  (z + 0.5f)), Quaternion.Euler(new Vector3(90, Random.Range(0, 360), 0)));
                        newGummibear.transform.SetParent(Torony.transform);
                    }
                }
                */

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
