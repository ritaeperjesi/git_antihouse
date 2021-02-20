using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ceilingGrow : MonoBehaviour
{
   // public GameObject ceiling;
  //  public Vector3 ceilingPosition = new Vector3(0, 0, 0);
  //  public float ceilingSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        // Changes the position to x:1, y:1, z:0
        transform.position = new Vector3(5, 8, 0);

    }

    // Update is called once per frame
    void Update()
    {
        // myMoveUp();
        // We add +1 to the x axis every frame.
        // Time.deltaTime is the time it took to complete the last frame
        // The result of this is that the object moves one unit on the x axis every second
        transform.position += new Vector3(0,  1 * Time.deltaTime,0);
    }

  /*  void myMoveUp()
    {
        ceilingPosition = GetComponent<Transform>().position;
        ceilingPosition.z += ceilingSpeed * Time.deltaTime;
        Instantiate(ceiling, ceilingPosition, Quaternion.identity);
    } */
}
