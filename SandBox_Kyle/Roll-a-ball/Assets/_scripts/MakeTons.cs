using UnityEngine;
using System.Collections;

public class MakeTons : MonoBehaviour {

    public Transform brick;

    void Start()
    {
        for (float y = -2.0f; y < 2.0f; y = y + 0.05f)
        {
            for (float x = -2.0f; x < 2.0f; x = x + 0.045f)
            {
                Instantiate(brick, new Vector3(x, y, 3), Quaternion.identity);
            }
        }
    }
}
