using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Linq;

public class UISetting : MonoBehaviour
{
    //public AudioMixer audioMixer; // ���ڿ���������AudioMixer
    public Dropdown qualityDropdown; // ���������˵�
    public Slider volumeSlider; // ����������
    public Button exitButton; // ���ذ�ť

    void Start()
    {
        // ��ʼ������ѡ��
        qualityDropdown.ClearOptions();
        qualityDropdown.AddOptions(QualitySettings.names.ToList());
        qualityDropdown.value = QualitySettings.GetQualityLevel();
        qualityDropdown.onValueChanged.AddListener(SetQuality);

        // ��ʼ������
        //float savedVolume = PlayerPrefs.GetFloat("Volume", 0.75f);
        //volumeSlider.value = savedVolume;
        //SetVolume(savedVolume);
        //volumeSlider.onValueChanged.AddListener(SetVolume);

        // ���ذ�ť�¼�
        exitButton.onClick.AddListener(OnBackButtonClicked);
    }

    // ��������
    //public void SetVolume(float volume)
    //{
    //    audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20); // ת��Ϊ�ֱ�
    //    PlayerPrefs.SetFloat("Volume", volume); // ������������
    //}

    // ���û���
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    // ���ذ�ť����¼�
    private void OnBackButtonClicked()
    {
        gameObject.SetActive(false); // �������ý���
    }
}