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

    // Sound Volume�� �����ϴ� �޼ҵ�
    private void UpdateVolume() // <- option �����ٲܶ� ȣ�����ֽø� �˾Ƽ� ���� ������ ���ŵȴ�.
    {
        bgmAudioSource.volume = SoundData.BgmVolume;
        sfxAudioSource.volume = SoundData.SfxVolume;
    }
}
