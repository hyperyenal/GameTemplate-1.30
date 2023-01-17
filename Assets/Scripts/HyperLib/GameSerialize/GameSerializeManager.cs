using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameSerializeManager
{
    private GameMaster gameMaster = default;
    private GlobalGameParams globalGameParams;
    public GameSerializeManager(GameMaster gM)
    {
        gameMaster = gM;
        globalGameParams = Resources.Load("GlobalGameParams") as GlobalGameParams;
    }

    public void LoadGameLevels(List<GameLevel> gameLevels)
    {

        TextAsset gameLevelsFile = Resources.Load(globalGameParams.dataDir + "TestData") as TextAsset;
        string[] lines = gameLevelsFile.text.Split(new char[] { '\n' });
        for (int i = 0; i < lines.Length; i++)
        {
            if (i == 0) continue; //ignore headers
            GameLevel gameLevel = new GameLevel();
            gameLevel.repeatingDatum = new List<GameLevel.LevelRepeatingData>();
            var values = lines[i].Split(',');
            for (int j = 0; j < values.Length; j++)
            {
                if (j == 0) { gameLevel.level = int.Parse(values[j]); continue; }
                if (j == 1) { gameLevel.intData = int.Parse(values[j]); continue; }
                if (j == 2) { gameLevel.stringData = values[j]; continue; }
                if (j > 2)
                {
                    GameLevel.LevelRepeatingData repeatingData = new GameLevel.LevelRepeatingData();

                    repeatingData.stringData = values[j++];
                    repeatingData.intData = int.Parse(values[j]);

                    gameLevel.repeatingDatum.Add(repeatingData);
                }
            }
            gameLevels.Add(gameLevel);
        }

    }

    public void DisplayGameLevelsData(List<GameLevel> gameLevels)
    {
        foreach (GameLevel gameLevel in gameLevels)
        {
            Debug.LogFormat("LEVEL: {0} IntData: {1} StringData: {2}", gameLevel.level, gameLevel.intData, gameLevel.stringData);
            foreach (GameLevel.LevelRepeatingData repeatingData in gameLevel.repeatingDatum)
            {
                Debug.LogFormat("Rep Data: StrData: {0} IntData: {1}", repeatingData.stringData, repeatingData.intData);
            }
        }
    }

    public void LoadPlayerInfo(PlayerInfo player)
    {
        PlayerInfo tmpPlayer;

        tmpPlayer = JsonUtility.FromJson<PlayerInfo>(PlayerPrefs.GetString("PLAYER_INFO"));

        if (tmpPlayer == null) // Player is playing the first time
        {
            player.playerID = Random.Range(1, 10000);
            player.playerName = "PseudoPlayer";
            player.lastPlayedLevel = 1;
            player.totalPoints = 0;
        }
        else
        {
            player.playerID = tmpPlayer.playerID;
            player.playerName = tmpPlayer.playerName;
            player.lastPlayedLevel = tmpPlayer.lastPlayedLevel;
            player.totalPoints = tmpPlayer.totalPoints;
        }
    }

    public void SavePlayerInfo(PlayerInfo player)
    {
        PlayerPrefs.SetString("PLAYER_INFO", JsonUtility.ToJson(player));
        PlayerPrefs.Save();
    }

    public void InitPlayerInfo()
    {
        PlayerInfo player = new PlayerInfo();
        player.playerID = Random.Range(1, 10000);
        player.playerName = "PseudoPlayer";
        player.lastPlayedLevel = 1;
        player.totalPoints = 0;

        PlayerPrefs.SetString("PLAYER_INFO", JsonUtility.ToJson(player));
        PlayerPrefs.Save();
    }
}
