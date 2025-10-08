using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    [Header("Inscribed")]               // Fields set in the Unity Inspector pane
    public GameObject projectilePrefab;
    public float velocityMult = 10f;
    public GameObject projLinePrefab;
    public LineRenderer lineRenderer;

    public Transform leftAnchor;
    public Transform rightAnchor;

    [Header("Dynamic")]                 // Fields that will be set dynamically when the game is running
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;

    void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
        launchPos = launchPointTrans.position;
    }

    void OnMouseEnter()
    {
        // print("Slingshot:OnMouseEnter()");
        launchPoint.SetActive(true);
    }


    void OnMouseExit()
    {
        // print("Slingshot:OnMouseExit()");
        launchPoint.SetActive(false);
    }


    void OnMouseDown()
    {
        // the player has pressed the mouse while over the Slingshot
        aimingMode = true;

        // instantiating a Projectile
        projectile = Instantiate(projectilePrefab) as GameObject;

        // Start it at the launchPoint
        projectile.transform.position = launchPos;

        // Set it to isKinematics for now
        projectile.GetComponent<Rigidbody>().isKinematic = true;

        lineRenderer.enabled = true;
        lineRenderer.positionCount = 3;

        lineRenderer.SetPosition(0, leftAnchor.position);
        lineRenderer.SetPosition(2, rightAnchor.position);
    }


    void Update()
    {
        // If Slingshot is not aimingMode, don't run this code
        if (!aimingMode)
        {
            return;
        }

        // Get the current mouse position in 2D screen coordinates
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        // Find the delta fromthe launchPos to the mousePos3D
        Vector3 mouseDelta = mousePos3D - launchPos;

        // Limit mouseDelta to the radius of the Slingshot SphereCollider
        float maxMagnitude = this.GetComponent<SphereCollider>().radius;
        if (mouseDelta.magnitude > maxMagnitude)
        {
            mouseDelta.Normalize();
            mouseDelta *= maxMagnitude;
        }

        // Move the projectile to this new position
        Vector3 projPos = launchPos + mouseDelta;
        projectile.transform.position = projPos;

        lineRenderer.SetPosition(1, projPos);

        if (Input.GetMouseButtonUp(0))
        {
            // the mouse has been released
            aimingMode = false;
            Rigidbody projRB = projectile.GetComponent<Rigidbody>();
            projRB.isKinematic = false;
            projRB.collisionDetectionMode = CollisionDetectionMode.Continuous;
            projRB.velocity = -mouseDelta * velocityMult;

            lineRenderer.enabled = false;

            // Switch to slingshot view immediately before setting POI
            FollowCam.SWITCH_VIEW(FollowCam.eView.slingshot);

            FollowCam.POI = projectile;         // Set the _MainCamera POI
            // Add a ProjectileLine to the Projectile
            Instantiate<GameObject>(projLinePrefab, projectile.transform);

            projectile = null;
            MissionDemolition.SHOT_FIRED();
        }
    }

    /*
        // Start is called before the first frame update
        void Start()
        {
        
        }

    */
}

