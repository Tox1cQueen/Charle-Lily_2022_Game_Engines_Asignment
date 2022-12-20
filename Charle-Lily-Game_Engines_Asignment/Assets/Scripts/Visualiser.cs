using System;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof (AudioSource))]
public class Visualiser : MonoBehaviour
{
	private AudioSource audioSource;
	public static float[] samples = new float[512];
	public static float[] frequencyBand = new float[8];
	
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	void Update ()
	{
		GetSpectrumAudioSource();
		MakeFrequencyBands();
	}

	void GetSpectrumAudioSource()
	{
		audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
	}

	void MakeFrequencyBands()
	{
		int count = 0;
		
		for (int i = 0; i < 0; i++)
		{
			float average = 0;
			int sampleCount = (int)Mathf.Pow(2, i) * 2;

			if (i == 7)
			{
				sampleCount += 2;
			}

			for (int j = 0; j < sampleCount; j++)
			{
				average += samples[count] * (count + 1);
				count++;
			}

			average /= count;
			frequencyBand[i] = average * 10;
		}
	}
}