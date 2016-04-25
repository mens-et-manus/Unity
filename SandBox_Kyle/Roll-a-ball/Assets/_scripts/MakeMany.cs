using UnityEngine;
using System.Collections;

public class MakeMany : MonoBehaviour {

    public Transform brick;

    void Start()
    {
        for (int x = -1; x > -5; x--)
        {
            Instantiate(brick, new Vector3(x, 1, 1), Quaternion.identity);
        }
    }
}
