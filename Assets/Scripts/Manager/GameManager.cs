using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private UserData userData
    //public UserData UserData { get; private set; }

    //[System.Serializable]

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }
}
