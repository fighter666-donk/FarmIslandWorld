using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public AudioMixer audioMixer;    // 进行控制的Mixer变量

    public void SetMusicVolume(float volume)    // 控制主音量的函数
    {
        audioMixer.SetFloat("Music", volume);
        // MasterVolume为我们暴露出来的Master的参数
    }

    public void SetSoundEffectVolume(float volume)    // 控制音效音量的函数
    {
        audioMixer.SetFloat("EffectVolume", volume);
        // EffectVolume为我们暴露出来的SoundEffect的参数
    }
}