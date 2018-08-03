using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MatrixPrinter
{
    public class MatrixPrinterManager : MonoBehaviour
    {

        [Header("Interface Components")]
        [SerializeField] private Button _matrixPrintButton;
        [SerializeField] private Text _matrixText;
        [SerializeField] private Text _matrixConfigurationText;

        [Header("Matrix")]
        [HideInInspector] private int[,] _matrix = 
                                                    { 
                                                        {1, 2, 3, 4, 5},
                                                        {6, 7, 8, 9, 10},
                                                        {11, 12, 13, 14, 15},
                                                        {16, 17, 18, 19, 20},
                                                        {21, 22, 23, 24, 25}
                                                    };

        private void Awake()
        {
            _matrixPrintButton.onClick.AddListener(() => OnMatrixPrintButtonClicked());
        }

        private void OnMatrixPrintButtonClicked()
        {
            //getting matrix lengths
            int rowsAmount = _matrix.GetLength(0);
            int columnsAmount = _matrix.GetLength(1);

            _matrixConfigurationText.text = "Rows: " + rowsAmount + "\n" + "Columns: " + columnsAmount;
            _matrixText.text = MatrixPrinter.MatrixClockwised(rowsAmount, columnsAmount, _matrix);
        }
    }
}
