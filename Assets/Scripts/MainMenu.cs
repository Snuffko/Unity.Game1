using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Animator _authorsPanelAnimator;
   
    public void Play()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void ChangeAuthorsPanelState()
    {
        _authorsPanelAnimator.SetBool("isOpen", !_authorsPanelAnimator.GetBool("isOpen"));
    }

    public void Exit()
    {
        Application.Quit();
    }
} 