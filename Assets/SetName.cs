using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetName : MonoBehaviour
{
    public Text name;

    void Start()
    {
        name.text = Dashboard.name;
    }
}
