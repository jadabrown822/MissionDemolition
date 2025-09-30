Mission Demolition
=====================

__1.__ Do the mIssion Demolition tutorial from Bond Chapter 30. Enhance the finished Mission Demolition project in the following ways:

> __a.__ use the Correct Unity vertion and upload to GitHub iwht the correct Unity gitignore.
>
> __b.__ Add a "Game Over" screen with a "Play Again" button.
>
> __c.__ Make 4 levels with 4 Castles different form the ones shoen in the book. Order the castles from easy to difficult, so that the game increases in difficulty with each level
>
> __d.__ Use a Line Reader to draw a rubber band of a slingshot
>
> __e.__ Add a sound. Either the rubber band snapping as the projectiile is shot, or the porjectile whirring as it flies though the air
>
> __f.__ Make the game cooler in a meaningful eay. Be sure to leave a readme file that explains the enhancements


# Getting Started: _Mission Demolition_
* __Project Template:__ 3D Core
* __Project Name:__ _Mission Demolition_
* __Scene Name__ _Scene_0
* __Game Pane Dimensions:__ Full HD (1920x1080)


# Game Prototype Concept
__1.__ When psyer's mouse pointer is in ange of the slingshot, the sling shot should glow

__2.__ If teh player presses the left mouse button (_mouse button 0_ in Unity) down while the sling shot is glowing, projectile will instantiate at teh locaion of the mouse pointer

__3.__ As the player moves and drags the mouse around with the mutton held down, the projectile folows it, yet remains within a specific distance of the slingshot

__4.__ A white line stretches from each arm of the slingshot around the projectille to make it look like the rubber band of an actual slingshot

__5.__ When the player releases mouse button 0, the projectile flies from the slingshot

__6.__ the player's goal is to knock down a castle that is several meters away and hit the target area inside

__7.__ The player has a total of three shots to hit the goal. The most recent shot will leave a trail so the player can better judge their next shot


# Art Assets
## Ground
__1.__ Open _Scene_0_. Make sure that you can see the contents of _Scene_0 in the hierarchy pane, which whould be Main Cmaera and Directional Light

__2.__ Create a cube (choose _GameObject > 3D Object > Cube_ from the menu bar)
> __a.__ Rename the cube to _Ground_
> 
> __b.__ To make a rectangualr solid that is very wide in the x direction, set its transform to the following
> * P:[0, 10, 0]
> * R:[0, 0, 0]
> * S:[100, 1, 4]

__3.__ Create a new material (_Assets > Create > Material_) and name it _Mat_Ground_
> __a.__ Give _Mat_Ground_ a brown _Albedo color
>
> __b.__ Also set the _Smoothness_ of the material to _0_ (the ground id not very shiny)
>
> __c.__ Attach the _Mat_Ground_ Material to the _Ground_ GameObjet in the Hierarchy)

__4.__ Save the Scene


## Directional Light
__1.__ Select _Directional Light_ in the Hierarchy pane. Change position and rotation:
* P:[-10, 0, 0]
* R:[30, -30, 0]
* S:[1, 1, 1]

__2.__ Save the Scene


## Camera Settings
__1.__ Select the _Main Camera_ in the Hierarchy and rename it to __MainCamera_

__2.__ Give __MainCamera Camera_  the following Transform setting
* P:[0, 0, -10]
* R:[0, 0, 0]
* S:[1, 1, 1]

__3.__ Give the _MainCamera Camera_ component these settings:
> __a.__ Set _Clear Flags_ to _SolidColor_
>
> __b.__ Choose a brighter _Background_ colot to look more like a sky blue.
> * [R: 75, G: 220, B: 255]
>
> __c.__ Set _Projection_ to _Orthographic_
>
> __d.__ Set size to _10_

__4.__ Choose _Full HD (1920x1080)_ aspect ratio in the Game pane

__5.__ Save the scene


## The Slingshot
__1.__ Create an empty GameObject (_GameObject > Create Empty_)
> __a.__ Change the empty GameObject's name to _Slingshot_
>
> __b.__ Reset the Slingshot's transform and set to the following:
> * P:[0, 0, 0]
> * R:[0, 0, 0]
> * S:[1, 1, 1]

__2.__ Create a new cylinder (_GameObject > 3D Object > Cylinder_)
> __a.__ Shange the name of the Cylinder to _Base_
>
> __b.__ Drag the Base under the Slingshot in the Hierarchy, making Slingshot its parent
>
> __c.__ Click the disclosure triangle next to the Slingshot and select _Base_ again
>
> __d.__ Set Base's transform to the following:
> * P:[0, 1, 0]
> * R:[0, 0, 0]
> * S:[0.5, 1, 0.5]

__3.__ With Base selected, click the three vertical dots next to the _Capsule Collider_ component in the Inspector and select _Remove Component_. This removes the Collider component from Base, which will keep the Projectile from frunning into it

__4.__ Create a new material named _Mat_Slingshot_
> __a.__ Set the _Albedo_ color to any light color
>
> __b.__ Set the _Smoothness_ to _0_
>
> __c.__ Drag _Mat_Slingshot_ on to _Base_ to applu the material to the Base GameObject

__5.__ Select _Base_ in the Hierarchy pane, and duplicate Base by choosing _Edit > Duplicate_ from the menu bar

__6.__ Change the name of the new duplicate fro _Base (1)_ to _LeftArm_. Set the transform of LeftArm to the following:
* P[0, 3, 1]
* R:[45, 0, 0]
* S:[0.5, 1.414, 0.5]

__7.__ Select _LeftArm_ in the Hierarchy
> __a.__ Duplicate LeftArm
>
> __b.__ Rename this instance from LeftArm (1) to RightArm
>
> __c.__ Set the transform of RightArm to the following:
> * P:[0, 3, -1]
> * R:[-45, 0, 0]
> * S:[0.5, 1.414, 0.5]

__8.__ Select the _Slingshot_ in the Hierarchy
> __a.__ Set the transform of Slingshot to the following:
> * P:[-10, -10, 0]
> * R:[0, 15, 0]
> * S:[1, 1, 1]
>
> __b.__ Add a Sphere Collider component to Slingshot (_Component > Physics > Sphere Collider_)
>
> __c.__ Set the Sphere Collider components to:
> * Set _Is Trigger_ to true (checked)
> * Set the _Y value of Center_ to 4
> * Set _Radius_ to 3

__9.__ Add a "launch point" to the slingshot to give it  specific location from which to shoot the projectiles
> __a.__ Select Slingshot in the Hierarchy
>
> __b.__ Create an empty GameObject as a child of Slingshot (_GameObject > Create > Empty Child_)
>
> __c.__ Rename the new empty child from GameObject to _LaunchPoint_
>
> __d.__ Set the _Transform_ of LaunchPoint to the following
> * P:[0, 4, 0]
> * R:[0, 15, 0]
> * S:[1, 1, 1]
> 
> __e.__ At the top of the _LaunchPoint_ Inspector, click the cube. Prom the pop-up menu, choose any of the dimonds on the bottom row of icons

__10.__ Save the scene


## Projectile
__1.__ Create a sphere in the scene (_GameObject > 3D Object > Sphere_) and name it _Projectile_

__2.__ Select _Projectile_ in the Hierarchy and attach _Rigidbody_ component (_Component > Physics > Rigidbody_)
> __a.__ Set _Mass_ to _5_ in the Projectile Rigidbody Inspector

__3.__ Create a new material and name it _Mat_Projectile_
> __a.__ Make Mat_Projectile's _Albedo_ a dark grey color
>
> __b.__ Set _Metalic_ to _0.5_ and _Smoothness_ to _0.65_ to make it look more like a metal ball
>
> __c.__ Apply Mat_Projectile to _Projectile_ in the Hierarchy

__4.__ Drag _Projectile_ from the Hierarchy pane to the Project pane to make it a prefab

__5.__ Delete the _Projectile_ instance that remains in the _Hierarchy_ pane

__6.__ Save the scene


# Coding the Prototype
## Createing the Slinghot Class
__1.__ Create a new C# script and name it _Slingshor.cs_ (_Assets > Create> C# Script_)
> __a.__ Attach the _Slingshot_ script to the _Slingshot_ GameObject in the Hierarchy
>
> __b.__ Open the Slingshot C# script in VS and enter the code

```cs
  // Slingshot.cs
  
  using System.Collections;
  using System.Collections.Generic;
  using UNityEngine;
  
  public class Slingshot : MonoBehaviour {
  
    void OnMouseEnter() {
      print("Slingshot:OnMouseEnter()");
    }


    void OnMouseExit() {
      print("Slingshot:OnMouseExit()");
    }
  
    /*
      void Start() {}
      void Update() {}
    */
  }
```

__2.__ Click _Play_ and move the mouse cursor close to the slingshot. Will see text in Console pane

__3.__ Save the scene


### Showing When the Slingshot Is Active
__1.__ Select _LaunchPoint_ in the Hierarchy
> __a.__ Add a _Halo_ component to LaunchPoint (_component > Effects > Halo_), which will create a gowing sphere effect at the Launch Point location
>
> __b.__ Set t'he _Size_ of the _Halo_ to 1
>
> __c.__ Make the _Color_ of the Halo to a light grey to make sure it's visible [r:191, g:191, b:191, a:255]

__2.__ Now add the code to the Slingshot C# script

```cs
  // Slingshot.cs
  
  using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;
  
  public class Slingshot : MonoBehaviour {
  
    public GameObject launchPoint;
  
  
    void Awake() {
      Transform launchPointTrans = transform.Find("LaunchPoint");
      launchPoint = launchPointTrans.gameIbject;
      launchPoint.SetActive(false); 
    }


    void OnMouseEnter() {
      // print("Slingshot:OnMouseEnter()");
      launchPoint.SetActive(true);
    }


    void OnMouseExit() {
      // print("Slingshot:OnMouseExit()");
      launchPoint.SetActive(false);
    }
  
    /*
      void Start() {}
      void Update() {}
    */
  }
```

__3.__ Save the _Slingshot_ script, return to Unity, and click _Play_

__4.__ Save the scene


### Instantiating a Projectile
__1.__ Copy code to _Slingshot.cs_

```cs
  // Slingshot.cs
  
  using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;
  
  public class Slingshot : MonoBehaviour {

    // fields set in tthe Unity Ispector pane
    [Header("Inscribed")]
    // meant to set within the Inspector
    public GameObject projectilePrefab;

    // fields set dynamically
    [Header("Dynamic")]
    // fields that will be set dynamically when the game is running
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;
  
  
    void Awake() {
      Transform launchPointTrans = transform.Find("LaunchPoint");
      launchPoint = launchPointTrans.gameIbject;
      launchPoint.SetActive(false);
      launchPos = launchPointTrans.position;
    }


    void OnMouseEnter() {
      // print("Slingshot:OnMouseEnter()");
      launchPoint.SetActive(true);
    }


    void OnMouseExit() {
      // print("Slingshot:OnMouseExit()");
      launchPoint.SetActive(false);
    }


    void OnMouseDown () {
      // the player has pressed the mouse button while over the Slingshot
      aimingMode = true;

      // instantiating a Projectile
      projectile = Instantiate(projectilePrefab) as GameOBject;

      // Start it at the launchPoint
      projectile.transform.position = launchPos;

      // Set it to isKinematic for now
      projectile.GetComponent<Rigidbody>().isKinematic = true;
    }
  
    /*
      void Start() {}
      void Update() {}
    */
  }
```

__2.__ Select _Slingshot_ in the Hierarchy pane and set _ProjectilePrefab_ to be the Projectile prefabe in the Project pane (clicking the target to the right of the projectilePrefab in the Inspector and choosing _Projectile_ from the _Assets_ tab)

__3.__ Click _Play_, move mouse pointer inside the active area for the slingshot, and click. The Projectile instance appears

__4.__ Add more to _Slingshot.cs_

```cs
  // Slingshot.cs
  
  using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;
  
  public class Slingshot : MonoBehaviour {

    // fields set in tthe Unity Ispector pane
    [Header("Inscribed")]
    // meant to set within the Inspector
    public GameObject projectilePrefab;
    public float velocityMult = 10f;

    // fields set dynamically
    [Header("Dynamic")]
    // fields that will be set dynamically when the game is running
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;
  
  
    void Awake() {
      Transform launchPointTrans = transform.Find("LaunchPoint");
      launchPoint = launchPointTrans.gameIbject;
      launchPoint.SetActive(false);
      launchPos = launchPointTrans.position;
    }


    void OnMouseEnter() {
      // print("Slingshot:OnMouseEnter()");
      launchPoint.SetActive(true);
    }


    void OnMouseExit() {
      // print("Slingshot:OnMouseExit()");
      launchPoint.SetActive(false);
    }


    void OnMouseDown () {
      // the player has pressed the mouse button while over the Slingshot
      aimingMode = true;

      // instantiating a Projectile
      projectile = Instantiate(projectilePrefab) as GameOBject;

      // Start it at the launchPoint
      projectile.transform.position = launchPos;

      // Set it to isKinematic for now
      projectile.GetComponent<Rigidbody>().isKinematic = true;
    }


    void Update() {
      // If Slingshot is not in aimingMode, don't run this code
      if (!aimingMode) {return;}

      // Get the current mouse position in 2D screen coordinates
      Vector3 mousePos2D = Input.mousePosition;
      mousePos2D.z = -Camera.main.transform.position.z;
      Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

      // Find the delta from the launchPos to the mousePos3D
      Vector3 mouseDelta = mousePos3D - launchPos;

      // Limit mouseDelta to the radius of the Slingshot SphereCollider
      float maxMagnitude = this.GetComponent<SphereCollider>().radius;
      if (mouseDelta.magnitude > maxMagnitude) {
        mouseDelta.Normalize();
        mouseDelta *= maxMagnetude;
      }

      // Move the projectile to this new position
      Vector3 projPos = launchPos + mouseDelta;
      projectile.transform.position = projPos;

      if (input.GetMouseButtonUp(0)) {
        // the mouse has been released
        aimingMode = false;
        RigidBody projRB = projectile.GetComponent<Rigidbody>().radius;
        projRB.isKinemaric = false;
        projRB.collisionDectionMode = CollisionDetectionMode.Continuous;
        projRB.velocity = -mouseDelta * velocityMult;
        projectile = null;
      }
    }
  
    /*
      void Start() {}
    */
    
  }
```

__5.__ Click _Play_ and see how the Slingshot feels. Adjust __velocityMult__ for correct feeling

__6.__ Save the scene


## Making a Follow Camera
__1.__ Select __MainCamera_ in the Hierarchy

__2.__ To create a new FollowCam Script and add it to _MainCamera at the same time:
> __a.__ click the _Add Component_ button at the bottom of the __MainCamera_ Inspector
>
> __b.__ Type _FollowCam_ into the search bar that appears
>
> __c.__ Click _New script_
>
> __d.__ Double-check the _FollowCam_ name and then click _Create and Add_

__3.__ Double-click the FollowCam script to open it

```cs
// FollowCam.cs

  using System.collections;
  using Systems.Collections.Generic;
  using UnityEngine;
  
  public class FollowCam : MonoBehaviour {
    startic public GameObject POI;    // The static point of interest
  
    [Header("Dynsmic")]
    public float camZ;    // The desired z pos of the camera
  
    void Awake() {
      camZ = this.transform.position.z;
    }
  
  
    void FixedUpdate() {
      // A single-line if statement doesn't require braces
      if (POI == null) return;    // if there is nor POI, then return
  
      // Get the position of poi
      Vector3 destination  = POI. transform.position;
  
      // Force destination.z to be camZ to keep the camera far enough away
      destination.z = camZ;
  
      // Set the camera to the destination
      transform.position = destination;
    }
  
    /*
      void Start() {}
    
      void Update() {}
    */
  }
```

__4.__ Open the _Slingshot_ C# script and add code

```cs
  // Slingshot.cs
  
  using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;
  
  public class Slingshot : MonoBehaviour {

    // fields set in tthe Unity Ispector pane
    [Header("Inscribed")]
    // meant to set within the Inspector
    public GameObject projectilePrefab;
    public float velocityMult = 10f;

    // fields set dynamically
    [Header("Dynamic")]
    // fields that will be set dynamically when the game is running
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;
  
  
    void Awake() {
      Transform launchPointTrans = transform.Find("LaunchPoint");
      launchPoint = launchPointTrans.gameIbject;
      launchPoint.SetActive(false);
      launchPos = launchPointTrans.position;
    }


    void OnMouseEnter() {
      // print("Slingshot:OnMouseEnter()");
      launchPoint.SetActive(true);
    }


    void OnMouseExit() {
      // print("Slingshot:OnMouseExit()");
      launchPoint.SetActive(false);
    }


    void OnMouseDown () {
      // the player has pressed the mouse button while over the Slingshot
      aimingMode = true;

      // instantiating a Projectile
      projectile = Instantiate(projectilePrefab) as GameOBject;

      // Start it at the launchPoint
      projectile.transform.position = launchPos;

      // Set it to isKinematic for now
      projectile.GetComponent<Rigidbody>().isKinematic = true;
    }


    void Update() {
      // If Slingshot is not in aimingMode, don't run this code
      if (!aimingMode) {return;}

      // Get the current mouse position in 2D screen coordinates
      Vector3 mousePos2D = Input.mousePosition;
      mousePos2D.z = -Camera.main.transform.position.z;
      Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

      // Find the delta from the launchPos to the mousePos3D
      Vector3 mouseDelta = mousePos3D - launchPos;

      // Limit mouseDelta to the radius of the Slingshot SphereCollider
      float maxMagnitude = this.GetComponent<SphereCollider>().radius;
      if (mouseDelta.magnitude > maxMagnitude) {
        mouseDelta.Normalize();
        mouseDelta *= maxMagnetude;
      }

      // Move the projectile to this new position
      Vector3 projPos = launchPos + mouseDelta;
      projectile.transform.position = projPos;

      if (input.GetMouseButtonUp(0)) {
        // the mouse has been released
        aimingMode = false;
        RigidBody projRB = projectile.GetComponent<Rigidbody>().radius;
        projRB.isKinemaric = false;
        projRB.collisionDectionMode = CollisionDetectionMode.Continuous;
        projRB.velocity = -mouseDelta * velocityMult;
        FollowCam.POI = projectile;    // Set the _MainCamera POI
        projectile = null;
      }
    }
  
    /*
      void Start() {}
    */
    
  }
```


### The Ground Is Too Small
__1.__ Fix by opening _Ground_ Transform pane to make larger
* P:[100, -10, 0]
* R:[0, 0, 0]
* S:[400, 1, 4]


### The Porjectile Doesn't Bounce Realistically
__1.__ Select the _Projectile_ prefab in the Project pane

__2.__ In the Projectile _Rigidbody_ component:
> __a.__ Open the disclosure triangle next to _Constraints_
>
> __b.__ Set the check box next to _Freeze Position Z_ to true
>
> __c.__ Set the check boxes next to _Freeze Rotation_ X, Y, and Z to true

__3.__ Save the scene, click _Play_, and try to launch the projectile again

__4.__ Fro the Unity menu bar, choose _Assets > Create > Physical Material_

__5.__ Name this Physical material _PhysMat_Projectile_

__6.__ Click _PhysMat_Projectile_ and set the _bounciness_ to 1 in the Inspector

__7.__ Drag _PhysMat_Projectile_ in the Project pane onto the _Projectile_ prefab to apply it to _SphereCollider_ component of the projectile

__8.__ Save the scene, click _Play_, and try launching the projectile again


### The Camera Needs Easing
__1.__ To start with easing to _FollowCam_

```cs
// FollowCam.cs

  using System.collections;
  using Systems.Collections.Generic;
  using UnityEngine;
  
  public class FollowCam : MonoBehaviour {
    startic public GameObject POI;    // The static point of interest

    [Header("Inscribed")]
    public float easing = 0.05f

    [Header("Dynsmic")]
    public float camZ;    // The desired z pos of the camera
  
    void Awake() {
      camZ = this.transform.position.z;
    }
  
  
    void FixedUpdate() {
      // A single-line if statement doesn't require braces
      if (POI == null) return;    // if there is nor POI, then return
  
      // Get the position of poi
      Vector3 destination  = POI. transform.position;

      // Interpolate from the current Camera position towards the destination
      destination = Vector3.Lerp(transform.position, destingation, easing);
  
      // Force destination.z to be camZ to keep the camera far enough away
      destination.z = camZ;
  
      // Set the camera to the destination
      transform.position = destination;
    }
  
    /*
      void Start() {}
    
      void Update() {}
    */
  }
```

__2.__ Add to _FollowCam_ to impose minimum X and Y limits on the FollowCam position, preventing it from going too far to the left or down

```cs
// FollowCam.cs

  using System.collections;
  using Systems.Collections.Generic;
  using UnityEngine;
  
  public class FollowCam : MonoBehaviour {
    startic public GameObject POI;    // The static point of interest

    [Header("Inscribed")]
    public float easing = 0.05f
    public Vector2 minXY = Vector2.zero;    // Vector2.zero is [0,0]

    [Header("Dynsmic")]
    public float camZ;    // The desired z pos of the camera
  
    void Awake() {
      camZ = this.transform.position.z;
    }
  
  
    void FixedUpdate() {
      // A single-line if statement doesn't require braces
      if (POI == null) return;    // if there is nor POI, then return
  
      // Get the position of poi
      Vector3 destination  = POI. transform.position;

      // Limit the minimum values of destination.x & destingation.y
      destination.x = Mathf.Max(minXY.x, destination.x);
      destination.y = Mathf.Max(minXY.y, destination.y);

      // Interpolate from the current Camera position towards the destination
      destination = Vector3.Lerp(transform.position, destingation, easing);
  
      // Force destination.z to be camZ to keep the camera far enough away
      destination.z = camZ;
  
      // Set the camera to the destination
      transform.position = destination;
    }
  
    /*
      void Start() {}
    
      void Update() {}
    */
  }
```


### Returning for Another Shot
__1.__ Open the FollowCam C# script in VS and modify the __FixedUpdate()__

```cs
// FollowCam.cs

  using System.collections;
  using Systems.Collections.Generic;
  using UnityEngine;
  
  public class FollowCam : MonoBehaviour {
    startic public GameObject POI;    // The static point of interest

    [Header("Inscribed")]
    public float easing = 0.05f
    public Vector2 minXY = Vector2.zero;    // Vector2.zero is [0,0]

    [Header("Dynsmic")]
    public float camZ;    // The desired z pos of the camera
  
    void Awake() {
      camZ = this.transform.position.z;
    }
  
  
    void FixedUpdate() {
    /*
      // A single-line if statement doesn't require braces
      if (POI == null) return;    // if there is nor POI, then return
  
      // Get the position of poi
      Vector3 destination  = POI. transform.position;
    */

      Vector3 destination = Vector3.zero;

      if(POI != null) {
        // If the POI has Rigidbody, check to see if it is sleeping
        Rigidbody poiRigid = POI.GetComponent<Rigidbody>();
        if((poiRigid != null) && poiRigid.IsSleeping()) {
          POI = null;
        }
      }

      if(POI != null) {
        destination = POI.transform.position;
      }

      // Limit the minimum values of destination.x & destingation.y
      destination.x = Mathf.Max(minXY.x, destination.x);
      destination.y = Mathf.Max(minXY.y, destination.y);

      // Interpolate from the current Camera position towards the destination
      destination = Vector3.Lerp(transform.position, destingation, easing);
  
      // Force destination.z to be camZ to keep the camera far enough away
      destination.z = camZ;
  
      // Set the camera to the destination
      transform.position = destination;
    }
  
    /*
      void Start() {}
    
      void Update() {}
    */
  }
```

__2.__ Adjust the _Sleep Threshold_ of the Unity Physics settings:
> __a.__ Choose _Edit > Project Settings_ from the Unity menu, and sleect the _Physics_ tab (not Physics 2D)
>
> __b.__ Change _Sleep Threshold_ from 0.005 to _0.01_ and close the Project Settings window

__4.__ Save the scene, and then play the game to see the camera reset


### Scaling the Camera Size to Keep the Ground in View
__1.__ Add lines to the FollowCam script

```cs
// FollowCam.cs

  using System.collections;
  using Systems.Collections.Generic;
  using UnityEngine;
  
  public class FollowCam : MonoBehaviour {
    startic public GameObject POI;    // The static point of interest

    [Header("Inscribed")]
    public float easing = 0.05f
    public Vector2 minXY = Vector2.zero;    // Vector2.zero is [0,0]

    [Header("Dynsmic")]
    public float camZ;    // The desired z pos of the camera
  
    void Awake() {
      camZ = this.transform.position.z;
    }
  
  
    void FixedUpdate() {
    /*
      // A single-line if statement doesn't require braces
      if (POI == null) return;    // if there is nor POI, then return
  
      // Get the position of poi
      Vector3 destination  = POI. transform.position;
    */

      Vector3 destination = Vector3.zero;

      if(POI != null) {
        // If the POI has Rigidbody, check to see if it is sleeping
        Rigidbody poiRigid = POI.GetComponent<Rigidbody>();
        if((poiRigid != null) && poiRigid.IsSleeping()) {
          POI = null;
        }
      }

      if(POI != null) {
        destination = POI.transform.position;
      }

      // Limit the minimum values of destination.x & destingation.y
      destination.x = Mathf.Max(minXY.x, destination.x);
      destination.y = Mathf.Max(minXY.y, destination.y);

      // Interpolate from the current Camera position towards the destination
      destination = Vector3.Lerp(transform.position, destingation, easing);
  
      // Force destination.z to be camZ to keep the camera far enough away
      destination.z = camZ;
  
      // Set the camera to the destination
      transform.position = destination;

      // Set the orthographicSize of the Camera to keep the Ground in view
      Camera.main.orthographicSize = destination.y + 10;
    }
  
    /*
      void Start() {}
    
      void Update() {}
    */
  }
```

__2.__ Click the _2D_ button at the top of the Scene pane to switch to 2D view (which will make this easier to see)

__3.__ Double-click _Ground_ in the Hierarchy to zoomm out and show the entire Ground GameObject in the Scene pane

__4.__ Select __Main_Camera_, click _Play_, and launch a projectile

__5.__ Stop playback, and save the scene


## Providing Vection and a Sense of Speed
### Importing Cloud Art
__1.__ Go to __http://book.prototools.net/clouds.unitypackage__ in any browser. This should download the clouds.unitypackage file in Downloads folder

__2.__ From the Unity menu bar, choose _Assets > Import Package > Custom Package_

__3.__ Navigate to the Downlaods folder, and choose _clouds.unitypackage_

__4.__ Click _Open_

__5.__ Click the _All_ button on the bottom-left of the Import Unity Package window to mkse sure that everything in the UnityPackage is selected

__6.__ Click the _Import_ button to bring these assets into the Project psne


### Using the Cloud Sprites in Our Game
__1.__ Create and Empty GameObject in the Scene (_GameObject > Create Empty_)
> __a.__ Rename this GameObject to _CloudCover_, and select it in the Hierarchy
>
> __b.__ Ensure that the CloudCover _Transform compontent is set to
> * P:[0, 0, 0]
> * R:[0, 0, 0]
> * S:[1, 1, 1]
>
> __c.__ In the CloudCover Inspector, click the _Add Component_ button and choose _New Script_
>
> __d.__ Name the new script _CloudCover_, and click _Create and Add_

__2.__ Open the _CloudCover_ script in VS and enter code

```cs
// CloudCover.cs
  
  using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;
  
  public class CloudCover : MonBehaviour {
    [Header("Inscribes")]
    public sprite[] cloudSprites;
    public int numClouds = 40;
    public Vector3 minPos = new Vector3(-20, -5, -5);
    public Vector3 maxPos = new Vector3(300. 40. 5);
    [Tooltip("For scaleRange, x is the min value, y is the max vlaue")]
    public Vector2 scaleRange = new Vector2(1, 4);
  
  
    void Start() {
      Transform parentTrans = this.transform;
      GameObject cloudGO;
      Transform cloudTrans;
      SpriteRenderer sRend;
      float scaleMult;
  
      for(int i = 0; i < numClouds; i++) {
        // Create a new GameObject (from scratch!) and get its Transform
        cloudGO = new GameObject();
        cloudTrans = cloudGO.transform;
        sRend = cloudGO.AddComponent<SpriteRenderer>();
  
        int spriteNum = Random.Range(0, cloudSprite.Lenght);
        sRend.sprite = cloudSprites[spriteNum];
  
        cloudTrans.position = RandomPos();
        cloudTrans.SetParent(parentTrans, true);
  
        scaleMult = Random.Range(scaleRange.x, scaleRange.y);
        cloudTrans.localScale = Vector3.one * scaleMult;
      }
    }
  
  
    Vector3 RandomPos() {
      Vector3 pos = new Vector3();
      pos.x = Random.Range(minPos.x, maxPox.x);
      pos.y = Random.Range(minPos.y, maxPox.y);
      pos.z = Random.Range(minPos.z, maxPox.z);
  
      return pos;
    }
  }
```

__3.__ Save the script, return to Unity, and select the _CloudCover_ GameObject in the Hierarchy. All Inscribed values for the CloudCover script have ben set, except for the cloudSprites
> __a.__ Open the _disclosure triangle_ for the _cloudSprites_ array in the in the CloudCover Component of the INspector
>
> __b.__ Type the number _5_ in the fied next to Cloud Sprites and press return/enter to add five empty elements to the array
>
> __c.__ Assign each of the five _clouds_ in the _Textures & Sprites_ folder of the Project pane to a slot in the _cloudSprites_ array

__4.__ Save the scene and click _Play_


## Organizing the Project Pane
__1.__ Create three folders (_Assets > Create > Folder_) in the Project pane named ___Scripts_, __Prefabs_, and _Materials_

__2.__ Drag the propper assets into the new folders in the Porject pane. Both the physic material and regular materials fo into the _Mateirials folder

__3.__ Change the default name of the _Scenes_ folder (Unity provided) to __Scenes_, which will keep it sorted above less-important assets


## Building the Castle
__1.__ Adjust the Scene pane so that viewing the scene from the back in isometric view
> __a.__ First make sure that te Scene is not in 2D view by clicking the 2D button of the Scene pane until it is not highlighted
>
> __b.__ Click the cone on the axes gizmo opposite of the z-axis
>
> __c.__ Click the three-lined arrow next to the word _Back_ un der the axes gizmo, it will become three parallel lines, signifying that its switched from a perspective to an isometric (i.e., orthographic) view

__2.__ Get rid of the Skybox view in the Scene pane. Click _Effects Pop-up_ at the top of the Scene pane

__3.__ Double-click __MainCamera_ in the Hierarchy to zoom the Scene pane to a good view from which to build the castle


### Making Walls and Slabs
__1.__ Create a dubplicate of the Mat_Ground material in the Project pane and name it _Mat_Stone_
> __a.__ Select _Mat_Ground_ in the Project pane
>
> __b.__ Choose _Edit > Duplicate_ from the Unity menu bar
>
> __c.__ Change the name from _Mat_Ground_ to _Mat_Stone_
>
> __d.__ Select _Mat_Stone_ and set the _Abledo_ Color to _50% gray_ (RGBA:[128, 128, 128, 255])

__2.__ Create a new cube (_GameOBjecy > 3D Object> Cube_) and rename it _Wall_
> __a.__ Set the _Wall_ Transform to
> * P:[0, 0, 0]
> * R:[0, 0, 0]
> * S:[1, 4, 4]
>
> __b.__ Add a Rigidbody Component to Wall (_Component > Physics > Rigidbody_)
>
> __c.__ In the Rigidbody component, click the _disclosure triangle_ next to _Constraints_ to see the options there. Constraining any aspect of the Rigidbody prevents it from changing that aspect
>
> __d.__ Constrain the _Z_ position of the Wall by setting the Reigidbody _Freeze Position Z_ to _true_. This wil prevent the Wall from moving out of the Z=0 plane in which the game takes palce
>
> __e.__ Set the _Freeze Rotation X_ and _Y_ to _true_. This still allowa the Rigid body to sping around the _Z_ axis, which is the only rotation that can see well from the orthographic _MainCamera
>
> __f.__ Se tthe Rigidbody Mass to _4_
>
> __g.__ Drag the Mat_Stone_ material onto WAll to color it grey

__3.__ Create a new script in the __Scripts folder named _RigidbodySleep_ and enter the code

```cs
// RigidbodySleep.cs

  using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;
  
  [RequireComponent(typeof(Rigidbody))]
  
  public class RigidbodySleep : MonoBehaviour {
    private int sleepCountdown = 4;
    private Rigidbody rigid;
  
  
    void Awake() {
      rigid = GetComponent<Rigidbody>();
    }
  
  
    void FixedUpdate() {
      if (sleepCountdown > 0) {
        rigid.Sleep();
        sleepCountdown--;
      }
    }
  
  /*
    void Start() {}
  
    void Update() {}
  */
  
  }
```

__4.__ Save the RigidbodySleep script and return to Unity

__5.__ Attach the _RigidbodySleep_ script to _Wall_

__6.__ Drag _Wall_ to the Project pane to make it a prefab (be sure ot put it in the _Prefabs folder), after doing so, selete the Wall instance from th eHierarchy pane

__7.__ Select the _Wall prefab in the _Prefabs folder of the Project pane and duplicate it
> __a.__ Rename Wall 1 to _Slab_
>
> __b.__ Double-click _Slab_ in the Project pane
>
> __c.__ Select _Slab_ in the Prefab Mode Hierarchy and set its transform to S:[4, 0.5, 4]
>
> __d.__ To return from Prefab Mode to a regular Scene view, either click the __<__ at the top left of the Hierarchy pane or click the word _Scenes_ next to the Unity logo that is near the top-left corner of the Scene view


### Making a Castle from Walls and Slabs
__1.__ Create an Empty GameObject to be the root node of the castle (_GameObject > Create Empty_)
> __a.__ Name it _Castle_
>
> __b.__ Set its transform to:
> * P:[10, 9.5, 0]
> * R:[0, 0, 0]
> * S:[1, 1, 1]

__2.__ Drag _Wall_ from the Hierarchy under Castle making it a child of Castle

__3.__ Make three duplicates of Wall and set the positions of each of th efour Walls to:
* __Wall__ P:[-6, 2, 0]
* __Wall (1)__ P:[-2, 2, 0]
* __Wall (2)__ P:[2, 2, 0]
* __Wall (3)__ P:[6, 2, 0]

__4.__ Drag _Slab_ from the _Prefabs folder of the Project pane under Castle, making it a child as well

__5.__ Make two dublicates of Slab and set the positions of the three Slabs to:
* __Slab__ P:[-4, 4.25, 0]
* __Slab (1)__ P:[0, 4.25, 0]
* __Slab (2)__ P:[4, 4.25, 0]

__6.__ Before setting up the next floor of the Castle, modify grid the grid settings
> __a.__ At the top of the Scene pane, click the grid icon of the _Grid Pop-up_ until it id higlighted in bright grey. The click the _downward facing triangle_ of the _Grid Pop-up_ to access its menu
>
> __b.__ Click the Three dots inthe top-right corner of the pop-up menu
>
> __c.__ Choose _Edit Grid and Snap Settings ..._
>
> __d.__ Under the _Increment Snap_ heading, ensure that the _Move X_ amount is _0.25_. Because all three dimentions are locked to each other, the settings for X will also set Y and Z
>
> __e.__ Close the _Grid and Snap_ window

__7.__ To make the second floor of the castle, use mouse to select any three adjacent Walls and the two Slabs above them
> __a.__ Duplicate them
>
> __b.__ Make sure that the Move tool is selected
>
> __c.__ Hold the Ctrl key and Move thme to be restingjust above the others. By holding Ctrl constrain the movement to the 0.25m grid that was set before, which should allow the exect position of the second floor. If need to tweak thier positions, the final positions for the nre Walls and Slabs should be as follows
> * __Wall (4)__ P:[-4, 6.5, 0]
> * __Wall (5)__ P:[0, 6.5 0]
> * __Wall (6)__ P:[4, 6.5, 0]
> * __Slab (3)__ P:[-2, 8.75, 0]
> * __Slab (4)__ P:[2, 8.75, 0]

__8.__ Continue the duplication and grid movemnet tricks to make the third floor by adding two more Walls and a Slab:
* __Wall (7)__ P:[-2, 11, 0]
* __Wall (8)__ P:[2, 11, 0]
* __Slab (5)__ P:[0, 13.25, 0]

__9.__ Add one final wall to the top off the Castle
* __Wall (9)__ P:[0, 15.5, 0]

__10.__ Make the Castle GameObject a prefab by dragging _Castle_ from the Hierarchy pane over to the __Prefabs_ folder of the Project pane

__11.__ Select the _Slab_ prefab in the Project pane and set its _Transform Scale X_ to _3.5_. Every Slab in the castle should reflect this change


### Making a Goal Using Nested Prefab
__1.__ Add a Goal cube to the Castle instance in the Hierarchy by _right-clicking_ on  the word _Castle_ in the Hierarchy and choosing _3D Object > Cube_ from the pop-up menu. This creates a new Cube as a child of Castle

__2.__ Rename the Cube to _Goal_

__3.__ Click _Castle_ in the Hierarchy and then click the _Overrides_ button near the top of the Castle Inspector pane. goal is listed as an instnace override of the Castle prefab

__4.__ In this same Overrides pop-up, click the _Apply All_ button. This applies all ovrerides on this instance back to the prefab itself. Now, the name of Goal is blue in the Hierarchy and the plus has dissappeared because Goal is now part of the Castle prefab

__5.__ Try dragging Goal to the _Prefabs folder of the Project paneto make it its own prefab, and there will be an error "Cannot restructure Prefab instance." To make structural changes to a prefab (like chinging a child of it from a regular GameObject to a prefab instance), need to use the Prefab Mode of the Scene pane

__6.__ Click _Open Prefab_ to open the Prefab Mode for Castle. This opens the Castle prefab qhile showing it within the _context_ of the scene. should see the other GameObjects in the scene ghosted around the Castle. If not, check the top of the scene pane to make sure that the _Context:_ mode is set to _Gray_
* _Prefab > Open Asset in Context_: This shows the prefab as it is positioned in the scene
* _Prefab > Open Asset in Isolation_: This shows the same prefab wihtout any context, and it is the same view if double-clicked the prefab in the Ptroject pane

__7.__ Make sure to be in one of the Prefab Mode views and then drag the _Goal_ GameObject from the Castle Hierarchy pane into the _Prefabs folder of the Project pane to make it its own prefab. Unity will allow it this time, and the icon for Goal in the Castle Hierarchy will turn blue to show that it's now a nested prefab (like the Walls and Slabs)

__8.__ Select _Goal_ in the Castle Hierarchy and look at the inspector and then select _Goal_ in the _Prefabs folder of the Project pane and see how the Inspector appears differently. Use this differnce to know whether editing in the prefab itself or one of its instances

__9.__ Select _Goal_ in the _Prefabs folder and set its Transform _scale_ to S:[3, 4, 4]. Setting the scale fo the prefav will change its instances (including nested ones)

__10.__ Select _Goal_ inthe _Prefabs folder and set it Transform _position_ to P:[0, 2, 0]. Notice that the Goal child of Castle does _not_ move to the new position. Position is such a common thing to change that it does not count as an override and is not carried over from a prefab to its instance. This is also true of rotation. Changing the roation of the prefab willnot change any of its instances

__11.__ Select the _Goal_ child of Castle in the Castle Hierarchy and set its position to P:[0, 2, 0]


### Configuring the Material and Collider of Goal
__1.__ Create new material in the _Materials_ folder named _Mat_Goal_
> __a.__ Drag _Mat_Goal_ onto the Goal prefab in the _Prefabs folder of the Project to apply it. May need to then select Goal in the Project pane for the material change to be reflected in the prefab Mode view
>
> __b.__ Select _Mat_Goal_ in the Project pane, and set its _Albedo_ color to a _bright green_ with an opacity of _50%_ (an RGBA in Unity color picker of [0, 255, 0, 128])
>
> __c.__ Set the _rendering Mode_ of Mat_Goal to _Transparent_, and notice that this allows the alpha value set to make the Goal translucent (this shows up more clearly in the Game pane)

__2.__ Right-click _Goal_ inthe Castle Hierarchy and choose _Prefab > Open Asset in Context_. See Goal within the context of Castle within the context of the Scene. Note the nesting "bread crumb trail" at the top of the Scene pane (showing "Scenes > Castle > Goal")
> __a.__ Select _Goal_ in teh Goal Herarchy
>
> __b.__ In the Goal _Box Collider_ Inspector, select _Is Trigger_ to make the Goal collider a trigger

__3.__ Return to the Scene Mode (by clicking the word _Scenes_ in the top-left of the Scene pane) and save the scene


### Testing the Castle
__1.__ Select the _Castle_ instance in the Hierarchy and set its position to P:[50, -9.5. 0]

__2.__ Click _Play_ and try to knock the Castle down with a Projectile


## Fixing Rigidbody's Insomia
__1.__ Add a new Projectile script to the Projectile prefab:
> __a.__ Select the _Projectile_ prefab in the Project pane
>
> __b.__ Click the _Add Component_ button at the bottom of the Projectile Inspector
>
> __c.__ Type _Projectile_ into the Add Component search box and click _New script_
>
> __d.__ Click _Create and Add_

__2.__ Move the _Projectile_ script into the ___Scripts_ folder

__3.__ Open the _Projectile script in VS and enter the code

```cs
// Projectile.cs

```
