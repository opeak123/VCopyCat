using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoWeekSingleton<SoundManager>
{
    [SerializeField]
    private AudioSource bgmAudioSource;

    [SerializeField]
    private AudioSource sfxAudioSource;

    private void Awake()
    {
        base.Awake();

    }

    // Sound Volume을 설정하는 메소드
    private void UpdateVolume() // <- option 볼륨바꿀때 호출해주시면 알아서 사운드 볼륨이 갱신된다.
    {
        bgmAudioSource.volume = SoundData.BgmVolume;
        sfxAudioSource.volume = SoundData.SfxVolume;
    }
}
