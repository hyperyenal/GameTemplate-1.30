using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameMaster : GenericSingletonClass<GameMaster>
{

    public bool onAir { get; set; }
    public int level { get; set; }
    public int totalPoints { get; set; }

    GameSerializeManager gameSerializeManager = default;
    public List<GameLevel> gameLevels = new List<GameLevel>();

    ParticleSystem successParticle = default;

    PlayerInfo player = new PlayerInfo();

    #region GamePatterns

    private GlobalGameParams globalGameParams;

    private UIBroker uiBroker;
    #endregion



    // Game Specific 

    public override void Awake()
    {
        base.Awake();
        globalGameParams = Resources.Load("GlobalGameParams") as GlobalGameParams;
        Assert.IsNotNull(globalGameParams);
        uiBroker = Resources.Load("UIBroker") as UIBroker;
        Assert.IsNotNull(uiBroker);
        gameSerializeManager = new GameSerializeManager(this);
        Assert.IsNotNull(uiBroker);

        onAir = false;
        level = 1;
    }
    void Start()
    {

        //successParticle = GameObject.Find("SuccessParticle").GetComponent<ParticleSystem>();
        //successParticle.Stop();

        onAir = false;
        LoadGameLevels(); //DisplayGameLevels(); for Debuging 
        InitPlayerInfo(); // Normally wont be necessary
        LoadPlayerInfo();

        //uiBroker.SwitchCanvas(ScreenNames.TutorScr);
    }

    void LoadGameLevels()
    {
        gameSerializeManager.LoadGameLevels(gameLevels);
    }

    void LoadPlayerInfo()
    {
        gameSerializeManager.LoadPlayerInfo(player);
        //Debug.LogFormat("Player Info Id: {0} Name: {1} level: {2}", player.playerID, player.playerName, player.lastPlayedLevel);
        level = player.lastPlayedLevel;
    }

    void SavePlayerInfo()
    {
        player.lastPlayedLevel = level;
        gameSerializeManager.SavePlayerInfo(player);
    }
    void InitPlayerInfo()
    {
        gameSerializeManager.InitPlayerInfo();
    }

    // For test purposes
    public void DisplayGameLevels()
    {
        gameSerializeManager.DisplayGameLevelsData(gameLevels);
    }

    public void DisplayLevel()
    {
        uiBroker.SetTotalPoints(this.totalPoints);

    }
    public void DisplayTotalPoints()
    {
        uiBroker.SetLevel(this.level);

    }

    public void PlayLevel()
    {
        SavePlayerInfo();
        //onAir = true;
        // 
        FireBaseTests.InitFireBase();
        FireBaseTests.DummyLogMessage();

    }

    public void PlayerSucceed()
    {
        //canvasManager.SwitchCanvas(ScreenNames.SuccessScr);
        successParticle.Play();
        Debug.Log("Player succedd");
        StartCoroutine(LevelEndCoroutine(ScreenNames.SuccessScr));
    }

    public void PlayerFailed()
    {
        uiBroker.SwitchCanvas(ScreenNames.FailScr);
        //successParticle.Play();
        //FailParticle.Play ();
        StartCoroutine(LevelEndCoroutine(ScreenNames.FailScr));
    }

    IEnumerator LevelEndCoroutine(ScreenNames screen)
    {
        uiBroker.SwitchCanvas(screen);
        onAir = false;
        yield return new WaitForSeconds(1f);
    }

    public void DebugGameName(string className)
    {
#if DEBUG1
        Debug.LogFormat("GameMaster=> Who Called Me ?: {0}", className);
#endif
    }
}

