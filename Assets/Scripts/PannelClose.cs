using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannelClose : MonoBehaviour
{
    [SerializeField] GameObject _pannel;
    public void Close()
    {
        _pannel.SetActive(false);
    }
}
