using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundData
{
    public static float BgmVolume
    {
        get
        {
            return PlayerPrefs.GetFloat("bgmSoundVolume", 1f);
        }
        set
        {
            PlayerPrefs.SetFloat("bgmSoundVolume", value);
        }
    }

    public static float SfxVolume
    {
        get
        {
            return PlayerPrefs.GetFloat("sfxSoundVolume", 1f);
        }
        set
        {
            PlayerPrefs.SetFloat("sfxSoundVolume", value);
        }
    }
}
