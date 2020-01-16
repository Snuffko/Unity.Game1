using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(GroundChecker))]
public class Player : MonoBehaviour
{
    [SerializeField] private Text _coinsValueDisplay;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;
    private GroundChecker _groundChecker;
    private int _coinsCollectCount; 
   
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _groundChecker = GetComponent<GroundChecker>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_groundChecker.CheckGround())
            {
                _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
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