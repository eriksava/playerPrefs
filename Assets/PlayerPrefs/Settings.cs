using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class Settings{

    public string axisname = "Horizontal";
    public float volume = 5f;
    public Difficulty difficulty;


}

public enum Difficulty{

    EASY,
    MEDIUM,
    HARD,
    INSANE

}
