using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

[CreateAssetMenu(fileName = "GlobalGameParams", menuName = "Hypernova/SObjs/GlobalGameParams")]
public class GlobalGameParams : ScriptableObject
{
    public string prefabsDir { get; private set; } = "Prefabs/";
    public string dataDir { get; private set; } = "Data/";
    public string fontsDir { get; private set; } = "Fonts/";
    public string imagesDir { get; private set; } = "Images/";
    public string ModelsDir { get; private set; } = "Models/";
    public string MaterialsDir { get; private set; } = "Materials/";
    public string TexturesDir { get; private set; } = "Textures/";
    public string PackagesDir { get; private set; } = "Packages/";
    public string IconsDir { get; private set; } = "Icons/";
    public string GameName { get; private set; } = "GameTemplate_1.30";
    public EventManager eventManager = new EventManager();

    /// Game Levels
    [System.Serializable]
    public class GameLevel
    {
        public string name;
        public int health;
        public int mana;
    }

    [System.Serializable]
    public class GameLevelList
    {
        public int initialLevel;
        public GameLevel[] gameLevel;
    }
    public GameLevelList myGameLevelList = new GameLevelList();


    void OnEnable()
    {
        TextAsset textAsset = Resources.Load(dataDir + "GameLevels") as TextAsset;
        Assert.IsNotNull(textAsset);

        myGameLevelList = JsonUtility.FromJson<GameLevelList>(textAsset.text);

        //Debug.Log(myGameLevelList.gameLevel[0].name);
        //Debug.Log(myGameLevelList.gameLevel[1].name);
    }
    void OnDisable()
    {

    }

    public GameLevel GetGameLevel(int level)
    {
        Assert.IsNotNull(myGameLevelList.gameLevel[level - 1]);
        return myGameLevelList.gameLevel[level - 1];
    }
    public int GetInitialLevel()
    {
        return myGameLevelList.initialLevel;
    }
}
