# UNITY TUTORIAL
## TABS
- **Hierarchy:** holds the game objects (create new with *right click*)
- **Inspector:** shows the details of a selected object (e.g. sprites, location, scripts). Right click to *Add Component*
- **Project:** shows all the folders and files in the game (e.g. audio files, scripts, scenes)
- **Scene:** shows the game in the workspace, which allows you to position objects and UI elements. The grey rectangle represents the camera/POV
- **Game:** shows the game *as it is going to be displayed*. Aspect ratio and resolution can be changed
- **Console:** used for debugging - displays errors and debugging measures
- **Package Manager:** contains all assets
- **Animation:** where animations are created
- **Animator:** where animations are connected. Contains the Parameter tab
- in File and then Build Settings, you can select the platform the project is made for

## Characters
- **sprite sheets** are used create animations, and importing them is more efficient
- sprite sheets can be simply dragged into the correct folder in Assets
- **sprite renderer** shows the sprite
- to create a normal sprite from a sprite sheet, change the *Sprite Mode* to multiple and use the *Sprite Editor* to *slice* the sprite sheet - can be done automatically by Unity

## Physics
- use *Add Component* to add RigidBody 2D
- Box Collider 2D is used to make a solid object (e.g. a floor)
- an object will not interact with other objects solidly unless it also contains a collider
- pick the collider with the most similar shape to your object
- *IsTrigger* is intangible but detects collision

## Audio
- *Audio Source* plays audio
- *OnAwake* plays when the game starts

 ## UI
 - right click on the Hierarchy and go to UI
 - you can add images, text, etc.
 - creating a UI element auto-creates a *Canvas*
 - this is what the UI elements exist on
 - to align the Canvas to the camera, change *Render Mode* into *Screen Space - Camera*
 - the *EventSystem* is used to detect input on elements of the UI
 - *Text* is distinct from *TextMeshPro*   

## CODE
### Movement
- **INPUT IS IN OLD VERSION OF UNITY INPUT HANDLING**
- call `using UnityEngine;` 
