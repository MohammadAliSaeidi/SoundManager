using UnityEngine;
using UnityEngine.Audio;
using Chromium.Utilities.Singleton;

public class SoundManager : SingletonMonoBehaviour<SoundManager>
{
	[SerializeField] private AudioMixer _audioMixer;

	/// <param name="value">Varies from 0 (Exclusive) and 1 (Inclusive)</param>
	public void SetMasterVolume(float value)
	{
		if (value > 1 || value <= 0)
		{
			Debug.LogError("Volume value must be between 0 (Exclusive) and 1 (Inclusive)");
			Mathf.Clamp(value, 0.001f, 1);
		}

		_audioMixer.SetFloat("MasterVolume", Mathf.Log10(value) * 20);
	}

	/// <param name="value">Varies from 0 (Exclusive) and 1 (Inclusive)</param>
	public void SetMusicVolume(float value)
	{
		if (value > 1 || value <= 0)
		{
			Debug.LogError("Volume value must be between 0 (Exclusive) and 1 (Inclusive)");
			Mathf.Clamp(value, 0.001f, 1);
		}

		_audioMixer.SetFloat("MusicVolume", Mathf.Log10(value) * 20);
	}
}
