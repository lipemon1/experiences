﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace IntegerToString
{
    public class ConversorExample : MonoBehaviour
    {
        [Header("Interface Components")]
        [SerializeField] private InputField _integerInputField;
        [SerializeField] private InputField _baseWantedInputField;
        [SerializeField] private Button _convertButton;
        [SerializeField] private Text _stringResultText;

        private void Awake()
        {
            //configuring ConvertButton
            _convertButton.onClick.AddListener(() => OnConvertButtonClicked(_integerInputField.text, _baseWantedInputField.text));
        }

        /// <summary>
        /// Method called when the Convert Button is clicked at Canvas
        /// </summary>
        /// <param name="inputValue"></param>
        /// <param name="baseWanted"></param>
        private void OnConvertButtonClicked(string inputValue, string baseWanted)
        {
            try
            {
                int intToConvert;
                int baseToUse; //I know, not checking if it's a valid base, sorry for that =/

                if (int.TryParse(inputValue, out intToConvert) && int.TryParse(baseWanted, out baseToUse))
                {
                    _stringResultText.text = CustomConversor.Itoa(intToConvert, baseToUse);
                }
                else
                {
                    _stringResultText.text = "A problem occur setting your conversion. Try another number.";
                }
            }
            catch (System.Exception e)
            {
                _stringResultText.text = e.Message;
            }
        }
    }
}
