using UnityEngine;
using System.Collections;

public class GameSelector : MonoBehaviour {

    public enum GameType { TigerStat, TigerSampling}//, TigerPredict }

    public static GameType curGameType = GameType.TigerSampling;
    public GameType _curGameType;

	void Start () {
        curGameType = _curGameType;
	}
}
