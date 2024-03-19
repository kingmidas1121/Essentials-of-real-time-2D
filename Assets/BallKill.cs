using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallKill : MonoBehaviour
{
 public AudioSource musicSource; // Ссылка на компонент AudioSource с музыкой, например, музыка для живого мячика
    public AudioClip destroyedMusic; // Музыка для уничтоженного мячика

    void Start()
    {
        // Находим AudioSource в сцене, если он не был присоединен в редакторе
        if (musicSource == null)
        {
            musicSource = FindObjectOfType<AudioSource>();
            if (musicSource == null)
            {
                Debug.LogError("AudioSource not found in the scene!");
            }
        }
    }

    void Update()
    {
        if (transform.position.y < -7.2)
        {
            Debug.Log("Death music is playing");
            PlayDestroyedMusic();
            Destroy(gameObject);
        }
    }
    void PlayDestroyedMusic()
    {
        musicSource.Stop(); // Останавливаем текущую музыку, если она проигрывается
        musicSource.clip = destroyedMusic; // Устанавливаем новую музыку для проигрывания
        musicSource.Play(); // Проигрываем новую музыку
    }
}
