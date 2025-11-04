# in-class-activities
## Devlogs
### W1
#### Finished
All Required work completed.

~~Attach camera to spine(Jaw_end)~~ Dizzy!!!

Added some random plane to climb.

Increase move speed and turn speed.

### W2
1: r, g, and b is the decimal between 0 and 1, so you need to use float.

2: _bounce is a natural numbers record how many times the ball touch the cat or wall, so you need to use int.

3: 0.1 is a **double** , not a **float**. 0.1f is the **float**. After every line of code, you will need to add a ";".

### W3

#1

DidPlayerHitBeat method need a bool return, show did player hit the beat. For parameters need a int show number of the beat, a float show when the player hit the screen. 

1:Class is a kind of thing like a mold, you can use it tu create different things. Component is the thing you created with the mlod like a cake. The member variables is the different thing on thing you create like different cream you use. And method is like eat this cake.

2:Because you only multiplie the color and not reset.

### W4

#4

Line 5: this line declares a member variable named _moveSpeed, and the type is float.

Line 22: this line declares a local variable named translation, and the type is float. the value is calculated by multiplying the _moveSpeed by deltaTime and vertical input axis.

Line 25: this line is calling a method Translate form Transform class, and passing the translation variable as an argument.

1: Cat and SoccerBall need a rigidbody component, and the Score need Is Trigger on. Because Cat and SoccerBall need physics, and the Score need to detect weatrher the ball touch it.

2: The cat need a fixed rotation.

### W5

#### Activity 1:

Q: If multiple components of the same type exist on an object, which one will GetComponent<>() return?

A: GetComponent<>() does not guarantee which component it will return. Its behavior is to ¡°return the first component of that type it finds.¡±

#### Activity 2:

1: Two member variables: _navMeshAgent(NavMeshAgent), _target(Transform).

2: The class need a Start method.

3: In the Start method, assign the _navMeshAgent variable by GetComponent<NavMeshAgent>(), and use _navMeshAgent.SetDestination(_target.position);.

### W6

BatW6 will need a float as speed, a Transform as target(player), a bool to decide should bat chase the player. A StartChase to set the bool variable to true, a StopChase to set the bool variable to false, and in the Update, move towards player if the bool variable is true.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 