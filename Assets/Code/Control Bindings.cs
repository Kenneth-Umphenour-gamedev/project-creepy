//-------------------------------------------------------------------------------------
// <copyright file="Project-creepy/Assets/Code/Control Bindings.cs" compyany="Project-Creepy Dev">
//    Author: Kenneth Umphenour
//    Copyright (c) Project-Creepy Dev. All rights reserved.
// </copyright>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Control Bindings", menuName = "Keybindings")]
public class ControlBindings : ScriptableObject
{
   public KeyCode up, down, left, right, interact, pause;
}
