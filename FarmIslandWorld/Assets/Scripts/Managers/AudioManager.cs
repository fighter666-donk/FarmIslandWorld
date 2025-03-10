using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public AudioMixer audioMixer;    // ���п��Ƶ�Mixer����

    public void SetMusicVolume(float volume)    // �����������ĺ���
    {
        audioMixer.SetFloat("Music", volume);
        // MasterVolumeΪ���Ǳ�¶������Master�Ĳ���
    }

    public void SetSoundEffectVolume(float volume)    // ������Ч�����ĺ���
    {
        audioMixer.SetFloat("EffectVolume", volume);
        // EffectVolumeΪ���Ǳ�¶������SoundEffect�Ĳ���
    }
}