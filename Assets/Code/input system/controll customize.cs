/* 
    <copyright file="controll customize.cs" company="Project-Creepy Dev">
    Copyright (c) 2020 All Rights Reserved
    </copyright>
    <author> Kenneth Umphenour </author>
    <summary>This script is to allow players to auto detect the controller type and customize the binndings</summary>

 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;
using UnityEngine.InputSystem.XInput;
public class controllcustomize : MonoBehaviour

void Awake(){
        if (gamepad is XInputController){
                Debug.Log("a Xbox One Contrller was connected");
        };
    else if (gamepad is DualShockGamepad){
        Debug.Log("a Dual Shock 4 controller was connected");
    };
    
    };
    };