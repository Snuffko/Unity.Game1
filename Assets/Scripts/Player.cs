using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Text _coinsValueDisplay;

    private Rigidbody2D _rigidbody;
    private GroundChecker _groundChecker;
    private int _coinsCollectCount;
   
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _groundChecker = GetComponent<GroundChecker>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_groundChecker.CheckGround())
            {
                _rigidbody.AddForce(Vector2.up * 125f, ForceMode2D.Impulse);
            }
        }
    }

    public void PickCoin()
    {
        _coinsCollectCount++;
        _coinsValueDisplay.text = _coinsCollectCount.ToString();
    }

    public void Die()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
