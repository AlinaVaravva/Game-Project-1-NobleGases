using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class WinScreenUI : Menu
{
    [SerializeField] private TMP_Text[] m_timers;
   
    public TMP_Text GetSetTimerText(int playerIndex)
    {
        return m_timers[playerIndex];
    }

    private void OnEnable()
    {
        // if (m_buttons != null)
        //     EventSystem.current.SetSelectedGameObject(m_buttons[0].gameObject);
    }

    public override void InitializeMenu()
    {
        m_buttons = GetComponentsInChildren<Button>();

        m_buttons[0].onClick.AddListener(delegate { SceneManagement.LoadScene(SCENES.MAINMENU); });

        //EventSystem.current.SetSelectedGameObject(m_buttons[0].gameObject);
    }

}
