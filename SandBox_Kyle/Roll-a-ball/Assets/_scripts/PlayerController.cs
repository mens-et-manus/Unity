using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float userInfluence;
    public float friendInfluence;

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

    //Before Physics
    void FixedUpdate()
    {
        //influence from keyboard
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 userInduced = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //influence from friends
        Vector3 position = transform.position;
        Vector3 peerPressure = new Vector3 (0, 0, 0);
        foreach (GameObject friend in friends)
        {
            Vector3 diff = friend.transform.position - position;
            //float curDistance = diff.sqrMagnitude;
            peerPressure = peerPressure + diff;
        }

        //add force
        rb.AddForce(userInfluence * userInduced + friendInfluence * peerPressure);
    }
}
