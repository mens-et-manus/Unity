using UnityEngine;
using System.Collections;

public class MakeMany2 : MonoBehaviour {

    public Transform brick;

    void Start()
    {
        for (float y = 1.0f; y < 4.0f; y = y + 1.0f)
        {
            for (float z = -2.0f; z < 2.0f; z = z + 1.0f)
            {
                for (float x = -1.0f; x > -4.0f; x = x - 1.0f)
                {
                    Instantiate(brick, new Vector3(x, y, z), Quaternion.identity);
                }
            }
        }
    }
}
