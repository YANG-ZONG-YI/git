using System;
using System.Text;
using System.Security.Cryptography;
using UnityEngine;

public class AuthHelper
{
    public static string ToMD5(string input)
    {
        string result = string.Empty;
        try
        {
            MD5 md5 = MD5.Create();  //工廠模式
            byte[] source = Encoding.Default.GetBytes(input); //string to bytes
            byte[] crypto = md5.ComputeHash(source); // md5
            result = BitConverter.ToString(crypto); //bytes to string
        }
        catch (Exception exp)
        {
            result = string.Empty;
            Debug.LogError(exp.ToString());
        }
        return result;
    }
}