# anino_exam

There is a problem building the APK file - I cannot fix it but it is working on Unity Remote 5.
FileNotFoundException: Failed to find $C:/Users/rhega/Documents/Unity Projects/2021.3.6f1/Editor/Data/PlaybackEngines/AndroidPlayer/Tools\GradleTemplates\mainTemplate.gradle
UnityEditor.Android.AndroidBuildPostprocessor.GetTemplate (System.String toolsPath, System.String fileName) (at <0bc7e9c04c1540528b26863a0cb726ae>:0)
UnityEditor.Android.AndroidBuildPostprocessor+<GetDataForBuildProgramFor>d__21.MoveNext () (at <0bc7e9c04c1540528b26863a0cb726ae>:0)
UnityEditor.Modules.BeeBuildPostprocessor.SetupBeeDriver (UnityEditor.Modules.BuildPostProcessArgs args) (at <44a70d1b13cf47e29810e30f45ffae08>:0)
UnityEditor.Modules.BeeBuildPostprocessor.PostProcess (UnityEditor.Modules.BuildPostProcessArgs args) (at <44a70d1b13cf47e29810e30f45ffae08>:0)
Rethrow as BuildFailedException: Exception of type 'UnityEditor.Build.BuildFailedException' was thrown.
UnityEditor.Modules.BeeBuildPostprocessor.PostProcess (UnityEditor.Modules.BuildPostProcessArgs args) (at <44a70d1b13cf47e29810e30f45ffae08>:0)
UnityEditor.Modules.DefaultBuildPostprocessor.PostProcess (UnityEditor.Modules.BuildPostProcessArgs args, UnityEditor.BuildProperties& outProperties) (at <44a70d1b13cf47e29810e30f45ffae08>:0)
UnityEditor.Android.AndroidBuildPostprocessor.PostProcess (UnityEditor.Modules.BuildPostProcessArgs args, UnityEditor.BuildProperties& outProperties) (at <0bc7e9c04c1540528b26863a0cb726ae>:0)
UnityEditor.PostprocessBuildPlayer.Postprocess (UnityEditor.BuildTargetGroup targetGroup, UnityEditor.BuildTarget target, System.Int32 subtarget, System.String installPath, System.String companyName, System.String productName, System.Int32 width, System.Int32 height, UnityEditor.BuildOptions options, UnityEditor.RuntimeClassRegistry usedClassRegistry, UnityEditor.Build.Reporting.BuildReport report) (at <44a70d1b13cf47e29810e30f45ffae08>:0)
UnityEngine.GUIUtility:ProcessEvent(Int32, IntPtr, Boolean&)


- Unity version used.
	= 2021.3.6f1

- System setup (main classes, controllers, objects)
	= Main classes
		-SlotItemData, SlotObject

	= Controllers
		-Game Manager, ReelController

	= Objects
		-GameManager, MainCamera, Atlas(group of bg UI and the reels), Canvas(interactable UIs), EventSystem

- List of data sources and how to edit them
	= SlotObjects = SymbolA-SymbolI (Assets->Scripts->SlotObjects)
	= Since it is a derived from a Scriptable objects you can edit it by pressing the Slot Item Data and change its values in the Inspector
	= You can also add another data source by presisng right click in the Project Tab->Create->SlotItemData

- Additional notes:
    - Discuss Scalability of system
		-The best resolution for the game is 1920xx1080 Landscape and I edit the settings to make sure that the game runs on landscape left only.

    - Discuss Flexibility of the system
		-Most of the variables are editable but are private, I make it into a SerialField to make sure that it can be edited in the Inspector Tab.

    - Discuss your use of MVC in the project
		-User->View->Model-Controller->User(I am not sure about this part since there is only limited knowledge that they teach us in our University.

    - What are the possible future improvements of your project
		-Implementation of Other UIs, Add more lines for rewards, and Better animation of slot machine.

Slot Machine Y values when rotating:
1.45
1.10
0.75
0.4
0.05
-0.3
-0.65
-1

Slot Objects 
A = 1
B = 2
C = 3
D = 4
E = 5
F = 6
G = 7
H = 8
I = 9
J = 10
