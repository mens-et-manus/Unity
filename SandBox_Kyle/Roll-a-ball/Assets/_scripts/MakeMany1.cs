using UnityEngine;
using System.Collections;

public class MakeMany1 : MonoBehaviour {

    public Transform brick;
    public float ymin;
    public float ymax;
    public float ystep;
    public float zmin;
    public float zmax;
    public float zstep;

    void Start()
    {
        for (float y = ymin; y < ymax; y = y + ystep)
        {
            for (float z = zmin; z < zmax; z = z + zstep)
            {
                for (float x = -1.0f; x > -4.0f; x = x - 1.0f)
                {
                    Instantiate(brick, new Vector3(x, y, z), Quaternion.identity);
                }
            }
        }
    }
}
