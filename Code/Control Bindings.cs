using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Control Bindings", menuName = "Keybindings")]
public class ControlBindings : ScriptableObject
{
   public KeyCode up, down, left, right, interact, pause;
}
