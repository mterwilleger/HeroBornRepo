using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IManager
{
    // hold the current state of adopting class
    string State { get; set; }
    // Adopting class to implement
    void Initialize();
}
