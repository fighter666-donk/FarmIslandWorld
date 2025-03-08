using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Linq;

public class UISetting : MonoBehaviour
{
    //public AudioMixer audioMixer; // 用于控制音量的AudioMixer
    public Dropdown qualityDropdown; // 画质下拉菜单
    public Slider volumeSlider; // 音量滑动条
    public Button exitButton; // 返回按钮

    void Start()
    {
        // 初始化画质选项
        qualityDropdown.ClearOptions();
        qualityDropdown.AddOptions(QualitySettings.names.ToList());
        qualityDropdown.value = QualitySettings.GetQualityLevel();
        qualityDropdown.onValueChanged.AddListener(SetQuality);

        // 初始化音量
        //float savedVolume = PlayerPrefs.GetFloat("Volume", 0.75f);
        //volumeSlider.value = savedVolume;
        //SetVolume(savedVolume);
        //volumeSlider.onValueChanged.AddListener(SetVolume);

        // 返回按钮事件
        exitButton.onClick.AddListener(OnBackButtonClicked);
    }

    // 设置音量
    //public void SetVolume(float volume)
    //{
    //    audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20); // 转换为分贝
    //    PlayerPrefs.SetFloat("Volume", volume); // 保存音量设置
    //}

    // 设置画质
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    // 返回按钮点击事件
    private void OnBackButtonClicked()
    {
        gameObject.SetActive(false); // 隐藏设置界面
    }
}