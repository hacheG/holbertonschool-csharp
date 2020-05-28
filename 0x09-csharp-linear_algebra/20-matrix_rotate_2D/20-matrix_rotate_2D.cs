using System.ComponentModel.DataAnnotations;
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
        int a = 1;
        int b = 2;
        int[] data = new int[9] {0,0,0,0,0,0,0,0,0};
        double[,] respuesta = new double[2, 2];
        double[,] rotacion  = new double[2, 2]{
                                                {Math.Round( Math.Cos(angle)), Math.Round(-Math.Sin(angle))},    
                                                {Math.Round(Math.Sin(angle)), Math.Round(Math.Cos(angle))}
                                              };
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (num != 0)
                    {
                        num -=4;
                    }
                    else if (num == 0)
                    {
                        num++;
                    }
                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        
                        data[num] = Math.Round( rotacion[i, j] * matrix[k, j]);
                        num +=4;
                    }
                }
            }
            for (int q = 0; q < matrix.GetLength(0); q++)
            {
                for (int w = 0; w < matrix.GetLength(0); w++)
                {
                    respuesta[q, w] = data[a] + data[b];
                    a+=2;
                    b+=2;


                }
            }
           
            
            return respuesta; 
        }
        
        
        return new double[,]{{-1}};
        

    }
}

