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
