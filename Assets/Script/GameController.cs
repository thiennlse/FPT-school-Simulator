using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { FreeRoam, Dialog, Battle}
public class GameController : MonoBehaviour
{
    [SerializeField] PlayerCrl PlayerCrl;

     GameState state;

    private void Update()
    {
        if (state == GameState.FreeRoam)
        {
           PlayerCrl.HandleUpdate();

        } else if (state == GameState.Dialog)
        {

        } else if(state == GameState.Battle)
        {

        }
    }
}
