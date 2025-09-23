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
> __a.__ change the name of the Cylinder to _Base_
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
> __a.__Set the _Albedo_ color to any light color
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

```ruby
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
    void start() {}
    void UPdate() {}
  */
}
```
