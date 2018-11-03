using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsExample : MonoBehaviour {


    public Settings playerSettings;
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.S)) // SAVE
        {
            SaveSettings(playerSettings);
            Debug.Log("SAVE DSETTINGS");
        }

        if (Input.GetKeyDown(KeyCode.L)) // LOAD
        {
            playerSettings = LoadSettings();
            Debug.Log("LOAD SETTINGS");
        }
        if (Input.GetKeyDown(KeyCode.D)) // DELETE ALL
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("DELETE ALL");
        }

    }

    void SaveSettings(Settings settings){

        PlayerPrefs.SetString("AXIS", settings.axisname);
        PlayerPrefs.SetFloat("VOLUME", settings.volume);
        PlayerPrefs.SetInt("DIFFICULTY", (int)settings.difficulty);

    }


    Settings LoadSettings(){

        var resultSettings = new Settings();

        resultSettings.axisname = PlayerPrefs.GetString("AXIS", "Horizontal");
        resultSettings.volume = PlayerPrefs.GetFloat("VOLUME", 5F);
        resultSettings.difficulty = (Difficulty)PlayerPrefs.GetInt("DIFFICULTY", 0);

        return resultSettings;

    }
}
