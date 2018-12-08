using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {
    public static float[] average = new float[8];
    public AudioSource m_audioSource;

    private float[] spectrum = new float[512];
    // Use this for initialization
    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        m_audioSource.GetSpectrumData(spectrum, 0, FFTWindow.Blackman);
        for (int i = 0; i < 8; i++)
        {
            average[i] = Getaverage(i * 64, (i + 1) * 64, spectrum);
        }
    }

    float Getaverage(int r1, int r2, float[] numbers)
    {
        float res = 0;
        for (int i = 0; i < (r2 - r1); i++)
        {
            res += numbers[r1 + i];
        }
        res = res / (r2 - r1);
        return res;
    }
}
