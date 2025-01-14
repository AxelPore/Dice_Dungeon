using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    private readonly System.Random random = new System.Random();
    public GameObject[] tiles;
    public static int[][] board = new int[10][];
    public static GameObject Gamecell;
    void printBoard()
    {
        string mess = "";
        for (int i = 0; i < 10; i++)
        {
            mess = "";
            for (int j = 0; j < 10; j++)
            {
                mess += board[i][j];
                mess += ", ";
            }
            mess += "\n";
            Debug.Log(mess);
        }
    }
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            board[i] = new int[10];
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                board[i][j] = 1;
            }
        }
        int voidToPlace = 10;
        while (voidToPlace > 0)
        {
            int Xrnd = random.Next(10);
            int Yrnd = random.Next(10);
            if (board[Xrnd][Yrnd] == 1)
            {
                board[Xrnd][Yrnd] = 2;
                voidToPlace--;
            }
        }
        int trapToPlace = 10;
        while (trapToPlace > 0)
        {
            int Xrnd = random.Next(10);
            int Yrnd = random.Next(10);
            if (board[Xrnd][Yrnd] == 1)
            {
                board[Xrnd][Yrnd] = 3;
                trapToPlace--;
            }
        }
        while (true)
        {
            int Xrnd = random.Next(10);
            int Yrnd = random.Next(10);
            if (board[Xrnd][Yrnd] == 1)
            {
                board[Xrnd][Yrnd] = 4;
                break;
            }
        }
        while (true)
        {
            int Xrnd = random.Next(10);
            int Yrnd = random.Next(10);
            if (board[Xrnd][Yrnd] == 1)
            {
                board[Xrnd][Yrnd] = 5;
                break;
            }
        }
        printBoard();
        for (int i = 0; i < board.Length; i++)
        {
            int change = 1;
            for (int j = 0; j < board[i].Length; j++)
            {
                Instantiate(tiles[board[i][j] - 1], new Vector3(i * 1.0607f + change * 0.5f * 0.53035f, j * 1.8107f - j*0.53035f, 0), Quaternion.identity);
                change *= -1;

            }
        }
    }
}
