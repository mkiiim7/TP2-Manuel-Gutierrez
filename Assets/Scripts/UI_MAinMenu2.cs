
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class UI_MAinMenu2 : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Button playButton;

    [SerializeField] private UnityEngine.UI.Button exitButton;

    [SerializeField] private UnityEngine.UI.Button settingsButton;

    [SerializeField] private UnityEngine.UI.Button creditsButton;

    [SerializeField] private UnityEngine.UI.Button settingsBackButton;

    [SerializeField] private GameObject pausePanel ;

    [SerializeField] private GameObject pausePanelButtons;

    [SerializeField] private GameObject PanelSettings;

    [SerializeField] private GameObject PanelMainCredits;

    [SerializeField] private Movement2 player1;

    [SerializeField] private Movement2 player2;

    [SerializeField] private UnityEngine.UI.Slider sliderspeedplayer1;

    [SerializeField] private UnityEngine.UI.Slider sliderspeedplayer2;

    public bool pausa = false;

    //public Movement speed11;

    public Movement2 speed22;
    

    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);

        exitButton.onClick.AddListener(OnExitButtonClicked);

        settingsButton.onClick.AddListener(OnSettingsButtonClicked);

        creditsButton.onClick.AddListener(OnCreditsButtonClicked);

        settingsBackButton.onClick.AddListener(OnSettingsBackButtonClicked);

        sliderspeedplayer1.onValueChanged.AddListener(OnSpeedPlayer1Changed);
        sliderspeedplayer2.onValueChanged.AddListener(OnSpeedPlayer2Changed);

    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))

        { 
            if (!pausePanel.activeSelf) 
            {
                pausa = true;
                pausePanel.SetActive(true);
                PanelSettings.SetActive(false);
                PanelMainCredits.SetActive(false);
                Debug.Log("Pausa = true");
                Time.timeScale = 0;
            }
            else
            {
                pausa = false;
                pausePanel.SetActive(false);
                pausePanelButtons.SetActive(true);
                //PanelMainCredits.SetActive(true);
                Debug.Log("Pausa = false");
                Time.timeScale = 1;
            }
        }

    }
    

    private void OnDestroy()
    {
        playButton.onClick.RemoveAllListeners();
        exitButton.onClick.RemoveAllListeners();
        settingsButton.onClick.RemoveAllListeners();
        creditsButton.onClick.RemoveAllListeners();
        settingsBackButton.onClick.RemoveAllListeners();
        sliderspeedplayer1.onValueChanged.RemoveAllListeners();
        sliderspeedplayer2.onValueChanged.RemoveAllListeners();

    }
    private void OnPlayButtonClicked()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    
    private void OnExitButtonClicked()
        {
        if (UnityEditor.EditorApplication.isPlaying)
            {
            UnityEditor.EditorApplication.isPlaying = false;
            }
        else 
            {
                Application.Quit();
            }
        }
    private void OnSettingsButtonClicked()
    {
        
        PanelSettings.SetActive(true);
        pausePanelButtons.SetActive(false);
        PanelMainCredits.SetActive(false);


    }

    private void OnCreditsButtonClicked()
    {
        PanelMainCredits.SetActive(true);
        PanelSettings.SetActive(false);
        pausePanelButtons.SetActive(false);



    }

    private void OnSettingsBackButtonClicked()
    {
        PanelMainCredits.SetActive(false);
        PanelSettings.SetActive(false);
        pausePanelButtons.SetActive(true);



    }
    
    private void OnSpeedPlayer1Changed(float speedP1)
    {
        speed22.speed2 = speedP1 ;

        if (speed22.speed2 > 10f )
        {
            speed22.speed2 = 10f;
        }
}

    private void OnSpeedPlayer2Changed(float speedP2)
    {
        speed22.speed2 = speedP2;

        if (speed22.speed2 > 10f)
        {
            speed22.speed2 = 10f;
        }
    }
}
