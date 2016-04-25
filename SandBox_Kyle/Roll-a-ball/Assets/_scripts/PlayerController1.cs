using UnityEngine;
using System.Collections;

public class PlayerController1 : MonoBehaviour {

    public float userInfluence;
    public float friendInfluence;
    public float lj12;
    public float lj6;

    private Rigidbody rb; //self
    private GameObject[] friends; //others

    // Use this for initialization
    void Start()
    {
        friends = GameObject.FindGameObjectsWithTag("Player");
        rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
	void Update ()
    {

    }

 //   private float LJ (float num)
   // {
     //   return lj12 * Mathf.Pow(num, -12.0f) - lj6 * Mathf.Pow(num, -6.0f);
    //}

    //Before Physics
    void FixedUpdate()
    {
        //influence from keyboard
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 userInduced = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //influence from friends
        Vector3 position = transform.position;
        Vector3 peerPressure = new Vector3 (0.01f, 0.01f, 0.01f);
        foreach (GameObject friend in friends)
        {
            Vector3 diff = friend.transform.position - position;
            if (Vector3.Magnitude(diff) > 0.01f)//should look out for zeroes
            {
                //Vector3 force = new Vector3(lj12 * Mathf.Pow(diff[0], -12.0f) - lj6 * Mathf.Pow(diff[0], -6.0f), lj12 * Mathf.Pow(diff[1], -12.0f) - lj6 * Mathf.Pow(diff[1], -6.0f), lj12 * Mathf.Pow(diff[2], -12.0f) - lj6 * Mathf.Pow(diff[2], -6.0f));
                Vector3 force = new Vector3(diff[0], 1, 1); //exponent of diff[0] returns NaN
                peerPressure = peerPressure + force;
            }
        }

        //add force
        rb.AddForce(userInfluence * userInduced + friendInfluence * peerPressure);
    }
}
