# GameTemplate_1_20

# News
- 3D URP
- CamBlends is added to Resources dir
- Timelines and Signals are added to Resources dir 
- Models dir moved from Resources dir to Supplementary dir

## Unity Related

- 2021.3.16f1 Release
- New Input Sistem
- Simulator Game Window
- Cinemachine Ready
- DEBUG1 ready. You can use **#if** blocks (Example gameMaster.DebugGameName). To disable Unity->Edit->Project Settings->Player->Scriping Defined Sysmbols Put a "/" in front of DEBUG1
- FireBase Integration ready

    ### **Scripts Folder**
    - HyperLib : Templete Scripts
    - ThisGame : This game specific scripts
    - TestScripts : Scripts for testing Hyperlib code. Uses TestScene
    ### **Resources Folder**
    - Directories for any kind of game reosurces ie. Textures, Prefabs. In this directory there exists also GlobalGameParams scriptable object asset whose source code is *Scripts/Hyperlib/GlobalGameParams.cs*. You can write all global game paramaters in this source code and the asset is modified automatically.

    - Resources folder holds UIBroker scriptle Object asset whose source code is *Scripts/HyperLib/CanvasManager/UIBroker.cs* . This is the communication channel between the UI and the rest of the game. 

    - TestReadGameParamsScene has TestReadGameLevels object. 


    ### **Suplementary**
    - Directoryes for external programs ie. Krita, blender.

## How to Start a Game
Clone the repository
```
git clone Repname
```
Enter username hyperyenal and accesstoken from mail. Create a new Scene (NewScene is built in this way). Add prefab **CanvasManager**. Add **EventSystem** from UI menu and convert this to New Input System. You can start writing your game in GameMaster.PlayLevel (). Write the name of the game to GlobalGameParams.GameName. To disable joyStick panel 
```c#
uiBroker.EnableJoyStickPanel(false);
```

## GameMaster

GameMaster A singleton extending GenericSingletonClass. GenericSingletonClass base class can be used for other singletons. You can use it by **GameMaster.Instance** For usage look at TestScripts/InputTestScript.cs. InputManager is a sigleton and it is automatically created. Dont forget to call 
```C#
base.Awake ();
```

Everything starts from GameMaster.Start (). Create a game object from Prefabs (already on the scene)

## GlobalGameParams
You can put all game related game parameters in this scriptable object. To access them
```C#
private GlobalGameParams globalGameParams;
``` 
in start or awake methodcase ScreenNames.FailScr:
```C#
globalGameParams = Resources.Load("GlobalGameParams") as GlobalGameParams;
Debug.Log (globalGameParams.dataDir);
```

Game Levels are also defined in this asset. Change GameLevel class with your game level structures/variables. You *GameLevels.json* file which resides in Data dir is a json file and should be compatiple with the GameLevel class. Then, you can access your level paramaters 
```C#
Debug.Log(globalGameParams.GetGameLevel(1).name);
```
name is a property of the GameLevel class and has an entry in the Json file. Example implementation is in *Scripts/TestScripts/ReadGameLevels.cs* which is attached to TestReadGameParamsScene/TestReadGameLevels game object

## GameSerializeManager
For reading and writing data to text files. Not MonoBehaviour, created by GameMaster

## EventManager
Not MonoBehaviour, for implementing Publisher/Subsriber pattern. Test code for pub and Sub are in TestScripts Dir.


- CanvasManager fro managing UI. Already on the MainScene
-
- GestureAndMovement/SmoothMovement for mouse movement 

## FSM Finete State Machine Functional Implementation
A functional implementation of a Finete State Machine (FSM). 

First you have to define your states with there actions

- State Entry action : executed once when this state in entered
- State Update Action : Executed in every frame while in this state
- State Exit Action : Executed when this state is exited

All of these actions can be null. 

```C#
FSMState state = new FSMState(StateEntryAction, StateUpdateAction|null, StateExitAction);
```

Then for each state you define the transition conditions
```C#
state.When(() => stateChangeContitionFunc, nextState, stateToNextStateAction);
```
state will exit (after running the stateExitAction) and execute stateToNextStateAction () and enter into nextState (and execute nextStateEntryAction)

TimeCondition(3f) is a special condition becomes true after specified seconds has elapsed

Define the finite State Machine 
```C#
fsm = new FSM(initialState);
fsm.AddStates(state1, state2, state3);
```
Put this line to update Method
```C#
fsm.ExecuteActions(fsm.Tick());
```
And write the actions. *TestScripts/FsmTest.cs* is a script for testing FSM.

## InputActions
Since this template is using Unity New Input System, TouchAct.inputActions defines 3 action Maps
- Touch
- Gkeyboard
- GMouse

And each has below actions and apropriate bindings

**Touch :** Tap, Move, DoubleTap, Position <br>
**Gkeyboard :** W, UpArrow, A, LeftArrow, S, DownArrrow, D, RightArrow, Space, J, K, L <br>
**GMouse :** LeftClick, RightClick, Move, Position

*HyperLib/InputManager/InputManager.cs* is the implementation class of the whole input system. 

*TestScrpts/InputTestScript.cs* is the test implementation of InputManager which is a singleton. On the test Scene there is also a ClickedObject whic implements the *ClickAble* interface for demostrating the movement and click.
 
## CanvasManager
THis is the UI of the game. Canvas manager gameObject is actually a canvas. There ara 5 game objects which ara also canvasas
- TutorSrc
- StartSrc
- FailSrc
- SuccessSrc
- PlaySrc

Game starts with TutorSrc on whic you can display a tutorial video or tutorial game. After that comes the StartSrc, which has a single button. Than PlaySrc which has totolpoints and level. FailSrc has nextLevel or Restart button. And SuccessSrc. 

Communication between UI and the rest of the game is done by UIBroker Scriptable Object. It is created by menu *Create/Brokers/UIBroker*. Game Template has already has one in *HyperLib/CanvasManager* directory. 

Every gameObject which has access to UI has a public UIBroken variable and it is assigned with the UIBroker asset in the inspector. UI operations are done by colling public functions of UIBroker variable. CanvasManager (panels, buttons, labels etc) is registered to UIBroker events. 

## JoyStick
It is under the Canvas manager and has own panel. It has saperate InputActions map *CharacterControlInputs* and movement in binded to the gamePad left stick. Canvas Manager has a reference to it and disables by default. 

The character (Capsule) has CharacterController component and *CharacterMan.cs* Script. It also has a reference to joyStick and enables in PlayCharacter Function. Uses UIBroker to be active and test should be adjusted in *ButtonActionsMan.cs*

## Gestures and Movement
In **MathAnimationScene** there is Player and Target objects. Player follows the target by 5 different movement types
- **SECONDORDER :** Velocity is calculated according the the velocity of previous frame. There are 3 parameters controlling the system<br>
    **F:** Frequency of the system, in a way time required to reach the target. 1 is normal value < 1 systems takes some time to     reach the target, > 1 almost moves with teh target<br>
    **Z:** Damping coofficient. Should not be 0, 0-1, system is underdamp ans will vibrate more or less depending on the magnitute of     Z. > 1 not vibrate, slowly settle towards the target, depending of the magnitute of Z.<br>
    **R:** Controls the initial respond of the system. 0, system takes time to begin accelerating from rest. > 0 reacts immediately.     > 1 overshoot the target. < 0 system will anticipate the motion
- **SLERP :** Spherical interpolation<br>
- **LERP :** Linear interpolation. Third parameter in both methods is the interpolation value. Time.deltaTime * speed is used<br>
- **SMOOTHDAMP :** Moves towards the target with ref velocity (Vector3 0 here) by using smoot time. Higher values mean object will reach the target in longer time <br>
- **TRANSLATE :** Not working correctly at the moment<br>

## FireBase
- Go to firebase console and start a new project
- On the Next page tick *Enable Google analytics for this project*
- Create or use an google analytics account
- GameTemplate 1-30 is the sample firebase project

Now, we will add  **Build/Cloud Firestore**. Then

- Add application to the project (IOS, Android, jS, Unity) from the Analytics Dashboard
- in page *Add Firebase to your Unity App* , register your IOS/Andproid App
- Write *Android Package Name* from *Unity/Edit/ProjectSettings/Player/PackageName*
- Give a nickName
- From project settings, Your apps, download *google.services.json* and put into Assets
- Download firebase unity SDK, unzip, *Assets/Import Package/Custom Package* Select 
    **FirebaseAnalytics.unitypackage**
    **FirebaseFirestore.unitypackage**
    Select all and import
- Example usage is in *TestScripts/FireBasetests.cs*



## Testing
There is mainScene for real gama generation and TestScene for testing.
Under TestScripts Dir, there are scripts for testing. Game objects for test scripts are in the TestScene
