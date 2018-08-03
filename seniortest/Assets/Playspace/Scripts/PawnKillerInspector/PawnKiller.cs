using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PawnKiller : MonoBehaviour {

    [Header("Secret Answer")]
    [SerializeField] private int _minFloorToBreak;

    [Header("Interface Components")]
    [SerializeField] private InputField _floorToJumpOffInputField;
    [SerializeField] private Button _startKillingButton;

    [Header("Killing Configuration")]
    [SerializeField] private int _availablePawns;
    [SerializeField] private int _maxFloor;

    private void Awake()
    {
        _startKillingButton.onClick.AddListener(() => StartCoroutine(DropPawnCo(_availablePawns, _maxFloor)));
        _floorToJumpOffInputField.onValueChanged.AddListener((value) => SetFloorToJumpOff(ConvertToInt(value)));
    }

    private int ConvertToInt(string newValue)
    {
        try
        {
            int intToConvert;

            if (int.TryParse(newValue, out intToConvert))
            {
                return intToConvert;
            }
            else
            {
                Debug.Log("[ERROR ON PARSE]");
                return -1;
            }
        }
        catch (System.Exception e)
        {
            Debug.Log("[ERROR ON PARSE] - " + e.Message);
            return -1;
        }
    }

    private void SetFloorToJumpOff(int newValue)
    {
        _floorToJumpOff = newValue;
    }

    private IEnumerator DropPawnCo(int pawnsToKill, int _maxFloor)
    {
        int floorToJump = _maxFloor / 2;


        while (pawnsToKill > 0)
        {
            if (floorToJump > _minFloorToBreak)
            {
                pawnsToKill++;
            } else if ( floorToJump < _minFloorToBreak);
            else
            {
                floorToJump
            }

            yield return null;
        }
    }

    private bool TryToBreakPawn(int floorTried, int floorNeeded)
    {
        return floorTried > floorNeeded;
    }
}
