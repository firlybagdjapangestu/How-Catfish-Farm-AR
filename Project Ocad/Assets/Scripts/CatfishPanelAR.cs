using TMPro;
using UnityEngine;

public class CatfishPanelAR : MonoBehaviour
{
    [SerializeField] private StepSO[] stepSO;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SelectedCatfish();
    }

    void SelectedCatfish()
    {
        int selectedStep = PlayerPrefs.GetInt("SelectedStep");
        if (selectedStep >= 0 && selectedStep < stepSO.Length)
        {
            audioClip = stepSO[selectedStep].stepSound;
        }
    }

    public void PlaySound()
    {
        if (audioSource != null)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
            else if (audioClip != null)
            {
                audioSource.clip = audioClip;
                audioSource.Play();
            }
        }


    }
}
