using UnityEngine;
using System.Collections;

public class Blocks : MonoBehaviour {

    void Start()
    {
        for (int y = 1; y < 5; y++)
        {
            for (int x = 1; x < 5; x++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.AddComponent<Rigidbody>();
                cube.transform.position = new Vector3(x, y, 0);
            }
        }
    }
}
