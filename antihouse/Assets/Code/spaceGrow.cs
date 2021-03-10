using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceGrow : MonoBehaviour
{
   // public GameObject ceiling;
   // public Vector3 ceilingPosition = new Vector3(0, 0, 0);
    public float ceilingSpeed = 1f;
    public float ceilingSpeed2 = 3f;
    // Start is called before the first frame update
    void Start()
    {
        // Changes the position to x:1, y:1, z:0
        transform.position = new Vector3(5, 10, 0);
     
    }

    // Update is called once per frame
    void Update()
    {
        // myMoveUp();
        // We add +1 to the x axis every frame.
        // Time.deltaTime is the time it took to complete the last frame
        // The result of this is that the object moves one unit on the x axis every second
        transform.position += new Vector3(0,  1 * Time.deltaTime * ceilingSpeed, 0);

        if (Time.deltaTime > 5.0f) {
            ceilingSpeed = ceilingSpeed2;
        }
    }

  /* void myMoveUp()
    {
        ceilingPosition = GetComponent<Transform>().position;
        ceilingPosition.z += ceilingSpeed * Time.deltaTime;
    
    } */
}
