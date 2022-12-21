using System;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Visualiser : MonoBehaviour
{
	private AudioSource audioSource;
	public static float[] samples = new float[512];

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	void Update()
	{
		GetSpectrumAudioSource();
	}

	void GetSpectrumAudioSource()
	{
		audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
	}
}

