# UNITY TUTORIAL
Disclaimer- **INPUT IS IN OLD VERSION OF UNITY INPUT HANDLING**


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
- use if statements to determine when an animation should be playing
- `anim.setBool(conditionName, true)` will set a parameter in the Animator to be true, where `anim` is the reference to the Animator
- to mirror the player, change the transform scale (make the requisite axis negative) or change the Flip property in the sprite renderer (`sr.flipX = true`)
- to reference the parameter, ensure that the name is definitely the same in code and in the animator
- if the animation seems a little delayed, find the drop-down list in the transition and change the transition duration
- also in the Animator, the animation speed can be changed (click on it, its at the top)
- 

## Physics
- use *Add Component* to add RigidBody 2D
- Box Collider 2D is used to make a solid object (e.g. a floor)
- an object will not interact with other objects solidly unless it also contains a collider
- pick the collider with the most similar shape to your object
- can edit the collider to exclude areas (like little bits of decoration)
- *IsTrigger* is intangible but detects collision
- for objects it is a good idea to use capsule colliders, as box colliders can sometimes catch

## Audio
- *Audio Source* plays audio
- *OnAwake* plays when the game starts

 ## UI
 - right click on the Hierarchy and go to UI
 - you can add images, text, etc.
 - creating a UI element auto-creates a *Canvas*
 - this is what the UI elements exist on
 - to align the Canvas to the camera, change *Render Mode* into *Screen Space - Camera*
 - *Screen Space - Overlay* means that the canvas will map to the game view
 - in *Scaler*, *Scale by Screen Size*, input the dimensions of the camera, and match width or height to 0.5
 - the *EventSystem* is used to detect input on elements of the UI
 - *Text* is distinct from *TextMeshPro*
### The Actual Stuff
 - a UI should be made in a new scene (Ctrl+N)
 - images can have `Anchors` which keep it in a certain position no matter how the screen changes
 - to create an image, create an image object and drag the requisite sprite onto the source image
 - can use the Stretch anchor and set values to 0 to make it full screen
 - to add a font into TextMeshPro, find the window Font Asset Creator and put the font into there
 - buttons are legacy but will probably be used anyway - attach scrips to `On Click`
 - to change scene, import `UnityEngine.SceneManagement` and use `SceneManager.LoadScene("Name")`
 - if a scene is not opening, go to File and Build Profile, Scene List, and add all scenes using Add Open Scene
 - use `UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name` to get the string name of the pressed button
 - to control the game, you can make a static instance of a GameManager (using `instance = this` if `instance = null` in `Awake()`)

## Prefabs
- just drag and drop a game object into the Prefabs folder
- it is effectively a saved template of that object
- **WHEN YOU CHANGE AN OBJECT IN THE HIERARCHY** go to overrides in the inspector and apply all changes, if you want it to be saved to the prefab
- if you want it to be saved to a different prefab, drag the object back to the Prefabs folder and make it a variant
- you can edit prefabs without them being on the Scene

## Layers & Backgrounds
- all sprites have a layer, as shown on the Sprite Renderer
- **Order in Layer** shows the order in which sprites are shown within a layer
- a new layer can be added in Sorting Layer
- for large backgrounds made of many smaller, repeated ones, make an empty object to act as a folder
- hold V to snap objects to others, to align them

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
- to change the type, use `type.Parse()`
- remember: static variables don't require an object to be created

### Basic Code
- the **Start()** function is the third function that is executed in Unity
- **awake** is first, **onEnable** is second
- to output things into the console, using `print();` or `Debug.log();`
- use string concatenation to print variables
- strings can be concatenated with +
- functions and polymorphism works the same as in Java
- **if statements**: `if (variable < 0) {  }`, `else if (variable >= 0) {  }`, `else {  }`
- if there is only one line after an if statement, you can omit the curly brackets
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

### Movement
#### Player
- call `using UnityEngine; using System.Collections; using System.Collections.Generic;`
- `movementX = Input.GetAxis("Horizontal");`
- `Input.GetAxis` returns a number from -1 (left) to 1 (right) when pressing one of the directional keys (Arrow or WASD)
- `GetAxisRaw` gives either 1, 0, or -1
- `GetAxis` gives decimals ramping up to either end
- `transform.position += Vector3(movementX, 0f, 0f) * moveForce * time.deltaTime;`
- `Vector3` is a 3D vector, so that a vector is added onto the current position
- `time.deltaTime` is the interval between frames, to smooth out the movement
#### Monster
- using velocity in the `FixedUpdate` (because they are solely moving on a line)
- use `body.linearVelocity = new Vector2(speed, body.linearVelocity.y);`, which sets the velocity to be constant (0) on the y and whatever the speed is on the x
- the speed will be equal and opposite depending on what side of the player the monster spawns, so they travel towards the player in a line
- we can set objects to become *kinematic* in the Rigidbody, so forces will affect them but Gravity will not (static has no forces also)

### Jumping
- use `Input.getButtonDown("Jump")` to determine when the button has been pressed down *only*
- getButtonUp returns true when the button is released
- getButton returns true while the button is held
- call PlayerJump in FixedUpdate, not Update; it is called every fixed intervals (usually used to do physics stuff)
- use `body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse) where body is a reference to the Rigidbody2D
- this denotes that the force of the jump is added on the y-axis, with an instant force (an impulse)
- mess with the gravity/mass to figure out jump stuff
- use a Boolean called `isGrounded` to detect if they are in the air
- set this to `false` when they jump, and then to `true` when they contact the ground
- built-in function `OnCollisionEnter2D(Collision2D collision)`
- `if (collision.gameObject.CompareTag(GROUND_TAG))` where `GROUND_TAG` is the tag on every ground object
- **issue: if only using getButtonDown and fixedUpdate the button can be a bit finicky (at least for me). Just remove down and it will be fine (albeit with a glitch)**

### Camera Follow
- get an attribute reference of the player's transform; `player = GameObject.FindWithTag("Player").transform`
- get the current position as a temporary value, then alter that temporary value to that of the player
- set the transform of the camera to the temporary value
- to find the player's values use `player.position.x` and `player.position.y`
- call this is `LateUpdate`, so that the player's position is calculated first and there's not jittering
- to create limits to the movement of the camera, make a minimum and a maximum
- `if (tempPos.x < minX) { tempPos.x = minX; }`

### Spawners
- should be empty game objects (tag them in the inspector's unity cube to make them visible)
- add a `GameObject[]` list to store the references of the enemies
- to add monsters, serialise the above field and then lock the inspector
- this allows you to Ctrl-Click all the monsters, and drag and drop them into the field
- if multiple spawners are using this script, do the same as the above with their positions
- create an `IEnumerator` so that the spawn can be called multiple times in intervals
- use `yield return new WaitForSeconds(n)` where `n` is a random number
- random number is generated with `Random.Range(1, 5)`, where lower bound is inclusive
- generate a random index to find which monster to spawn and where (if multiple spawners and works as such)
- use `Instantiate()` to create the game object inside the brackets
- use 'Monster.transform.position` and set that to the position of the spawner
- to use a public component from another GameObject, `ObjectName.GetComponent<scriptName>().function()` etc.

### Collision and Destruction
- to detect a collision, at least one must have a Rigidbody
- use the same syntax as the IsGrounded tag
- `Destroy(gameObject)` deletes an object from the game
- this means that any references to that object will return an error - fix void functions with `if (null) { return; }`
- if the colliding object is not solid, ensure `IsTrigger` is ticked on the collider
- use the `OnTriggerEnter2D(Collider2D collision)` function and `if (collision.CompareTag(ENEMY_TAG)` to check if collision
- **OR** use `OnCollisionEnter2D(Collision2D collision)` and `if (collision.gameObject.CompareTag(ENEMY_TAG))`
- to make sure some things can't collide (e.g. every enemy) add a layer, go into Settings then Physics 2D, and untick the respective box on the matrix
- to remove enemies when they're outside of a certain distance/go out of the game, add empty objects with colliders that remove then om collision

### Changing Scenes
- to make sure a game object is not destroyed when changing scene, put `DontDestroyOnLoad(gameObject)` in `Awake`
- the full pattern is `if (instance == null) { instance = this; DontDestroyOnLoad(gameObject); } else { Destroy(gameObject); }`
- this ensures there's only ever one object, and that it exists through scene changes
- to determine when a scene has changed, use `private void OnLevelFinishedLoading(UnityEngine.SceneManagement.Scene scene, LoadSceneMode mode)` function
- refer to this in `OnDisable` and `OnEnable`
- use `scene.name` to get the string value of the string gam

### Events and Delegates
- in the sender;
 - declare a delegate with `public delegate void DelName();`
 - declare an event with `public static event DelName DelNameInfo;`
 - in a test, the event like a function as long as it is not null; this calls the listener wherever it appears
 - to call an event in actuality, use `Invoke("Method", 5f)` where `Method` is the name of a method containing the above, and 5f is the number of seconds until it is called
 -   
- in the reciever
 - `Sender.DelNameInfo += DelNameListener;` in OnEnable()
 - `DelNameListener()` function that shares the same type as the delegate (in this case void)
 - unsubscribe to an event with `Sender.DelNameInfo -= DelNameListener;` in OnDisable()
- if there is a parameter in the delegate, the Listener function must also have that parameter
- if the Listener has a return the value that is returned appears in the Console
