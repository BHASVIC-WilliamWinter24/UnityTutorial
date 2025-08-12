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
- the sprite sheet then has a drop down menu with each individual slice
- create an **Animator Controller**
- add an **Animator** onto the object, then put the above controller into the controller field on that animator
- enter the **Animation** tab while the object is selected, select *Create*, and name the Animation
- if there is already an animation, click the name in the upper left corner and create new
- Drag sprites into the Animation tab to create an animation
- the **Animator** tab allows transitions between animations
- transitions appear as white lines, and require conditions
- use the Parameters tab and the drop-down menu, and assign that Parameter to the condition of a transition

## Physics
- use *Add Component* to add RigidBody 2D
- Box Collider 2D is used to make a solid object (e.g. a floor)
- an object will not interact with other objects solidly unless it also contains a collider
- pick the collider with the most similar shape to your object
- can edit the collider to exclude areas (like little bits of decoration)
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
### Variables & Operations
- `type name;` or `type name = value;`
- **floats** are decimal numbers, and should end with an f: `float speed = 5f;`
- **doubles** do not have the f at the end (doubles are larger)
- **ints** are integers
- **strings** are multiple characters, in quotes: `string name = "James";`
- **chars** are single characters, in single quotes: `char letter = 'a';`
- **bools** are true/false values
- the basic operations are the normal: + - / *
- / of integers round down

### Basic Code
- the **Start()** function is the third function that is executed in Unity
- **awake** is first, **onEnable** is second
- to output things into the console, using `print();` or `Debug.log();`
- use string concatenation to print variables
- strings can be concatenated with +
- functions and polymorphism works the same as in Java
- **if statements**: `if (variable < 0) {  }`, `else if (variable >= 0) {  }`, `else {  }`
- **OR** = `||`, **AND** = `&&`
- **switch-case statements**: `switch (variable) {  case (value): etc case (value): etc  }`
- remember to use `break:` to break from the switch-case
- **for loops**: `for(int i = 0; i < 10; i++) {  }` - same as Java
- **while loops**: `while(condition == value) {  }` - same as Java

### Coroutine
- primarily used to delay an execution
- use `IEnumerator` instead of void in the function
- this means you must return an 'IEnumerator' using `yield return new WaitForSeconds(time)` where time is a float
- the above statement can be used multiple times in the function
- call using `StartCoroutine(coroutineName());`
- `StopCoroutine(coroutineName());` allows the coroutine can be paused

### Classes
- a blueprint from which objects are created
- the constructor is named after the class
- attributes are initialised outside of any functions
- classes are fundamentally the same as in Java
- public and private are also the same: private is only accessible from within the class
- getters and setters are replaced by accessibility modifiers
- for attribute 'health';
     `private int _health;`
     `public int Health { get { return _health; } set { _health = value } }`
- use this by simply saying className.Health = 50

### Inheritance
- to use inheritance, replace MonoBehaviour with the name of the parent class
- `public class Goblin : Enemy`
- gives the child class access to all the functions and attributes of the superclass, but not vice versa
- this minimises the amount of code that must be written
- can override inherited functions/attributes by setting the parent's function as a `public virtual` function
- the child's function must be a `public override` function _(doesn't need to be public but must be in this order)_
- every class by default inherits `MonoBehaviour`

### Components
- when components are added to an object, they can be initialised into the script of that object
- `private Rigidbody2D body = GetComponent<Rigidbody2D>();` where `body` is the reference
- this allows the script to manipulate the functions of the attached components
- Monobehaviour allows access to the Transform component through `transform`

### Prefabs
- just drag and drop a game object into the Prefabs folder
- it is effectively a saved template of that object

### Movement
- **INPUT IS IN OLD VERSION OF UNITY INPUT HANDLING**
- call `using UnityEngine; using System.Collections; using System.Collections.Generic;`
- get the direction of travel using `Input.GetAxis("Horizontal");` and `Input.GetAxis("Vertical");`
- using a `Vector2` to represent the position
