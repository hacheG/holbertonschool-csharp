﻿using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;
using System;

///<summary>Class for matrix math</summary>
class MatrixMath
{
    ///<summary>calcuating matrix multiplication</summary>
	///<return>the result matrix or matrix containing -1</return>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int num = 0;
        int[] data = new int[9] {0,0,0,0,0,0,0,0,0};
        double[,] respuesta = new double[2, 2];
        double[,] rotacion  = new double[2, 2]{
                                                {Math.Cos(angle), -Math.Sin(angle)},    
                                                {Math.Sin(angle),Math.Cos(angle)}
                                              };
        if (matrix.GetLength(0) == 2)
        {
            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (num != 0)
                    {
                        num -=4;
                    }
                    for (int k = 0; k < 2; k++)
                    {
                        num++;
                        data[num] = rotacion[i, j] * matrix[j, k];
                        num +=4;
                    }
                }
            }
            respuesta[0, 0] = data[1] + data[2];
            respuesta[0, 1] = data[3] + data[4]; 
            respuesta[1, 0] = data[5] + data[6]; 
            respuesta[1, 1] = data[7] + data[8];
            
            return respuesta; 
        }
        else
        {
            return new double[,]{{-1}};
        }

    }
}
