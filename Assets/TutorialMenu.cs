using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialMenu : Menu
{
    [SerializeField] private float        m_tutorialDuration;
    [SerializeField] private GameObject[] m_tutorialBackGrounds;
    [SerializeField] private Slider       m_slider;

    private int   m_currentTutorial;
    private float m_currentDuration;

    // Start is called before the first frame update
    public override void InitializeMenu()
    {
        m_currentDuration = 0.0f;
        m_currentTutorial = 0;
        m_slider.maxValue = m_tutorialDuration;        
    }

    private void OnEnable()
    {        
        m_tutorialBackGrounds[0].SetActive(true);
        m_tutorialBackGrounds[1].SetActive(false);
    }

    void Update()
    {   
        if(m_currentDuration < m_tutorialDuration)
        {
            m_currentDuration += Time.deltaTime;
            m_slider.value = m_currentDuration;
        }
        else
        {
            m_tutorialBackGrounds[m_currentTutorial].SetActive(false);
            m_currentTutorial++;

            if(m_currentTutorial == m_tutorialBackGrounds.Length)
            {
                SceneManagement.LoadScene(SCENES.LEVEL1);
                return;
            }
            m_tutorialBackGrounds[m_currentTutorial].SetActive(true);
            m_tutorialDuration += 2.0f;
            m_slider.maxValue = m_tutorialDuration;
            m_currentDuration = 0.0f;
            m_slider.value    = 0.0f;
        }
    }


}
