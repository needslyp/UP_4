using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject firstScreen;
    [SerializeField] private GameObject secondScreen;

    private GameObject _currentScreen;

    private void Start()
    {
        _currentScreen = firstScreen;
        firstScreen.SetActive(true);
    }

    public void ChangeState(GameObject state)
    {
        if (_currentScreen != null && state != null){
            _currentScreen.SetActive(false);
            state.SetActive(true);
            _currentScreen = state;
        }
    }
}
