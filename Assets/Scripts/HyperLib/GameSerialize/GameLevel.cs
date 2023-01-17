using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameLevel
{
    public struct LevelRepeatingData
    {
        public string stringData;
        public int intData;
        public LevelRepeatingData(string str, int pInt)
        {
            stringData = str;
            intData = pInt;
        }
    }

    public int level;
    public int intData;
    public string stringData;
    public List<LevelRepeatingData> repeatingDatum;
};

public class PlayerInfo
{
    public int playerID;
    public string playerName;
    public int lastPlayedLevel;
    public int totalPoints;
}