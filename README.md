# Unity_Beginner_Scripting
https://learn.unity.com/project/beginner-gameplay-scripting

Notes:

Scripts as Behaviour Components
Differents ways to add and create a script
Variables and Functions
Introduction to Variables and Functions (also referred to as method). Differences between void and functions that return data. Uses Debug.Log to see the results.
Conventions and Syntax
Dot operator allows you to access a compound item in Unity. ";"", indentation and comments
IF Statements
Decide IF condition is satisfied.
Loops
For Loop, While loop, Do While Loop and Foreach Loop.
"WhileLoop" tests the condition before the loop body.
"DoWhileLoop" tests the condition at the end of the body.
Scope and Access Modifiers
Difference between Private and Public functions. If the public variable located at "void Start()," it will not be overridden by the value at the inspector. All variables are private unless it is declared as public. Other scripts can access public variables.
Awake and Start
Awake is called first, even if the script component is disabled. Used for references between scripts and initialization. Start is called before the first update.
Update and FixedUpdate
Update
Called every frame
Used for regular updates such as:
Moving non-physics objects
Simple Timers
Receive Input
Update interval times vary
FixedUpdate
Called every physics step
Intervals are consistent
Used for regular updates such as:
Adjust physics (Rigidbody) objects.
Vector Maths
dot product
cross product
Enabling and Disabling Components
myLight.enabled = !myLight.enabled;
Can work as a toggle
Activating GameObjects
Translate and Rotate
Look At
It moves the camera to face a moving object constantly. 
Linear Interpolation
Examples of how to perform linear interpolation on Unity.

Destroy
Destroy the component; the object is still present; only its mesh render is no longer visible. You can also add time to wait after the destroy command.

GetButton and GetKey
Ways to set up buttons. Like GetButton Up, GetButton Down, GetButton. Buttons need to be specified on the input menu.

GetAxis
Returns a value instead of being press or not press. From -1 to 0. It even includes dead zone for joysticks.

OnMouseDown
To detect a click on GUI text element or a collider.

GetComponent
Accessing public variables from other scripts using GetComponent. It should be used on the awake since it is expensive in terms of processing power.

DeltaTime
Its the time between each Update or FixedUpdate. Used to smooth values or movement.

Data Types
Value
int
float
bool
char
Structs (contain one or more variable)
Vector3
Quaterion 
Reference (Object of a class)
Classes
Transform
GameObject

Classes
Container for variables and functions.

Instantiate
Creates clones of game objects (prefabs). Can use position, rotation, and a Rigidbody.
Arrays
Collection of data of the same type together.
Invoke
Call a function after a specified time delay.
Enumerations
A special data type that has a specific subset of sub-values. Like a Compass (North , East, South, West).
Switch Statements
Alternative to IF condition. Compare a single variable to a series of constants.
