using System.Collections;
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
            _convertButton.onClick.AddListener(() => OnConvertButtonClicked(_integerInputField.text, _baseWantedInputField.text));
        }

        private void OnConvertButtonClicked(string inputValue, string baseWanted)
        {
            try
            {
                int intToConvert;
                int baseToUse;

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
