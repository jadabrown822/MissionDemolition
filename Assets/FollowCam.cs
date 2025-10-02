using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    static public GameObject POI;       // the static point of interest

    [Header("Dynamic")]
    public float camZ;          // the desired z pos of the camera


    void Awake()
    {
        camZ = this.transform.position.z;
    }


    void FixedUpdate()
    {
        if (POI == null) return;        // if there is not POI, then return

        // Get the position of poi
        Vector3 destination = POI.transform.position;

        // Force destination.z to be camZ to keep the camera far enough away
        destination.z = camZ;

        // Set the camera to the destination
        transform.position = destination;
    }

    /*
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    */
}
