using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Animator _authorsPanelAnimator;
   
    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void OnAuthorsButtonClick()
    {
        _authorsPanelAnimator.SetBool("isOpen", !_authorsPanelAnimator.GetBool("isOpen"));
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
    }
} 