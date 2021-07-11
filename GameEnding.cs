using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup YouLoseBackgroundImage;
    bool m_IsPlayerFell;
    float m_Timer;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerFell = true;
        }

    }

    void Update()
    {
        if (m_IsPlayerFell)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        m_Timer += Time.deltaTime;
        YouLoseBackgroundImage.alpha = m_Timer / fadeDuration;
        if(m_Timer > fadeDuration + displayImageDuration)
        {
            Application.Quit();
        }

    }
}
