using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text coinsText, winningsText, betText;
    [SerializeField] private ReelController[] reels;
    private string[] combinations;

    [SerializeField] private int totalCoins, winnings, bet;


    private bool reset;

    private void Start()
    {
        reset = true;
        totalCoins = 100;
        winnings = 0;
        bet = 50;
    }
    private void Update()
    {
        coinsText.text = "Player Coins: " + totalCoins;
       
        betText.text = "Total Bet: " + bet;

        if (reset == false)
        {
            if (reels[0].GetComponent<ReelController>().finishedSpinning && reels[1].GetComponent<ReelController>().finishedSpinning && reels[2].GetComponent<ReelController>().finishedSpinning && reels[3].GetComponent<ReelController>().finishedSpinning && reels[4].GetComponent<ReelController>().finishedSpinning)
            {
                string row2 = "", row1 = "", row0 = "";

                combinations = new string[5];

                for (int i = 0; i < 5; i++)
                {
                    combinations[i] = reels[i].GetComponent<ReelController>().stoppedSlot;
                }

                for (int y = 0; y < 5; y++) // rows
                {
                    string str = combinations[y];
                    row0 += str.Substring(0, 1);
                    row1 += str.Substring(1, 1);
                    row2 += str.Substring(2, 1);
                }

                Debug.Log("Row2: " + row2 + " | Row1: " + row1 + " | Row0: " + row0);

                Winnings(row0, row1, row2);

                reset = true;
            }
        }
    }

    public void ReelSpin()
    {
        reset = false;
        totalCoins -= bet;
        int i = 0;

        foreach (ReelController rC in reels)
        {
            rC.finishedSpinning = false;

            if (rC.reelStoped)
                rC.CanSpin();

        }
    }

    public void DecreaseBet()
    {
        bet -= 10; 
    }

    public void IncreaseBet()
    {
        bet += 10;
    }

    public void MaxBet()
    {
        bet = totalCoins;
    }


    private void Winnings(string r0, string r1, string r2)
    {
        bool won = false;
        winnings = 0;
        int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0, h = 0, i = 0, j = 0;

        #region R0
        foreach (char x in r0)
        {
            if (x == 'A')
                a++;
            else if (x == 'B')
                b++;
            else if (x == 'C')
                c++;
            else if (x == 'D')
                d++;
            else if (x == 'E')
                e++;
            else if (x == 'F')
                f++;
            else if (x == 'G')
                g++;
            else if (x == 'H')
                h++;
            else if (x == 'I')
                i++;
            else if (x == 'J')
                j++;
        }

        Debug.Log(a + "" + b + "" + c + "" + d + "" + e + "" + f + "" + g + "" + h + "" + i + "" + j);

        if (a == 3 || d == 3 || g == 3 || j == 3)
            winnings += (reels[0].symbols[1].CheckPayout(2) * bet);
        else if (b == 3 || e == 3 || h == 3)
            winnings += (reels[0].symbols[1].CheckPayout(2) * bet);
        else if (c == 3 || f == 3 || i == 3)
            winnings += (reels[0].symbols[1].CheckPayout(2) * bet);
        else
            winnings += reels[0].symbols[1].CheckPayout(0);

        if (a == 4 || d == 4 || g == 4 || j == 4)
            winnings += (reels[0].symbols[1].CheckPayout(3) * bet);
        else if (b == 4 || e == 4 || h == 4)
            winnings += (reels[0].symbols[1].CheckPayout(3) * bet);
        else if (c == 4 || f == 4 || i == 4)
            winnings += (reels[0].symbols[1].CheckPayout(3) * bet);
        else
            winnings += reels[0].symbols[1].CheckPayout(0);

        if (a == 5 || d == 5 || g == 5 || j == 5)
            winnings += (reels[0].symbols[1].CheckPayout(4) * bet);
        else if (b == 5 || e == 5 || h == 5)
            winnings += (reels[0].symbols[1].CheckPayout(4) * bet);
        else if (c == 5 || f == 5 || i == 5)
            winnings += (reels[0].symbols[1].CheckPayout(4) * bet);
        else
            winnings += reels[0].symbols[1].CheckPayout(0);
        #endregion

        #region R1
        a = 0; b = 0; c = 0; d = 0; e = 0; f = 0; g = 0; h = 0; i = 0; j = 0;
        Debug.Log(a + "" + b + "" + c + "" + d + "" + e + "" + f + "" + g + "" + h + "" + i + "" + j);
        foreach (char x in r1)
        {
            if (x == 'A')
                a++;
            else if (x == 'B')
                b++;
            else if (x == 'C')
                c++;
            else if (x == 'D')
                d++;
            else if (x == 'E')
                e++;
            else if (x == 'F')
                f++;
            else if (x == 'G')
                g++;
            else if (x == 'H')
                h++;
            else if (x == 'I')
                i++;
            else if (x == 'J')
                j++;

           // Debug.Log(x);
        }

        if (a == 3 || d == 3 || g == 3 || j == 3)
            winnings += (reels[0].symbols[1].CheckPayout(2) * bet);
        else if (b == 3 || e == 3 || h == 3)
            winnings += (reels[0].symbols[1].CheckPayout(2) * bet);
        else if (c == 3 || f == 3 || i == 3)
            winnings += (reels[0].symbols[1].CheckPayout(2) * bet);
        else
            winnings += reels[0].symbols[1].CheckPayout(0);

        if (a == 4 || d == 4 || g == 4 || j == 4)
            winnings += (reels[0].symbols[1].CheckPayout(3) * bet);
        else if (b == 4 || e == 4 || h == 4)
            winnings += (reels[0].symbols[1].CheckPayout(3) * bet);
        else if (c == 4 || f == 4 || i == 4)
            winnings += (reels[0].symbols[1].CheckPayout(3) * bet);
        else
            winnings += reels[0].symbols[1].CheckPayout(0);

        if (a == 5 || d == 5 || g == 5 || j == 5)
            winnings += (reels[0].symbols[1].CheckPayout(4) * bet);
        else if (b == 5 || e == 5 || h == 5)
            winnings += (reels[0].symbols[1].CheckPayout(4) * bet);
        else if (c == 5 || f == 5 || i == 5)
            winnings += (reels[0].symbols[1].CheckPayout(4) * bet);
        else
            winnings += reels[0].symbols[1].CheckPayout(0);

        Debug.Log(a + "" + b + "" + c + "" + d + "" + e + "" + f + "" + g + "" + h + "" + i + "" + j);
        #endregion

        #region R2
        a = 0; b = 0; c = 0; d = 0; e = 0; f = 0; g = 0; h = 0; i = 0; j = 0;
        foreach (char x in r2)
        {
            if (x == 'A')
                a++;
            else if (x == 'B')
                b++;
            else if (x == 'C')
                c++;
            else if (x == 'D')
                d++;
            else if (x == 'E')
                e++;
            else if (x == 'F')
                f++;
            else if (x == 'G')
                g++;
            else if (x == 'H')
                h++;
            else if (x == 'I')
                i++;
            else if (x == 'J')
                j++;
            //Debug.Log(x);
        }

        if (a == 3 || d == 3 || g == 3 || j == 3)
            winnings += (reels[0].symbols[1].CheckPayout(2) * bet);
        else if (b == 3 || e == 3 || h == 3)
            winnings += (reels[0].symbols[1].CheckPayout(2) * bet);
        else if (c == 3 || f == 3 || i == 3)
            winnings += (reels[0].symbols[1].CheckPayout(2) * bet);
        else
            winnings += reels[0].symbols[1].CheckPayout(0);

        if (a == 4 || d == 4 || g == 4 || j == 4)
            winnings += (reels[0].symbols[1].CheckPayout(3) * bet);
        else if (b == 4 || e == 4 || h == 4)
            winnings += (reels[0].symbols[1].CheckPayout(3) * bet);
        else if (c == 4 || f == 4 || i == 4)
            winnings += (reels[0].symbols[1].CheckPayout(3) * bet);
        else
            winnings += reels[0].symbols[1].CheckPayout(0);

        if (a == 5 || d == 5 || g == 5 || j == 5)
            winnings += (reels[0].symbols[1].CheckPayout(4) * bet);
        else if (b == 5 || e == 5 || h == 5)
            winnings += (reels[0].symbols[1].CheckPayout(4) * bet);
        else if (c == 5 || f == 5 || i == 5)
            winnings += (reels[0].symbols[1].CheckPayout(4) * bet);
        else
            winnings += reels[0].symbols[1].CheckPayout(0);

        Debug.Log(a + "" + b + "" + c + "" + d + "" + e + "" + f + "" + g + "" + h + "" + i + "" + j);
        #endregion
        totalCoins += winnings;
        Debug.Log("Coins: " + totalCoins);
        winningsText.text = "Total Winnings: " + winnings;

        /* if(r0 == "BBBBB")
             totalCoins += reels[0].symbols[1].CheckPayout(4);
         else if (r0 == "DBBBB" || r0 == "BDBBB" || r0 == "BBDBB" || r0 == "BBBDB" || r0 == "BBBBD")
             totalCoins += reels[0].symbols[1].CheckPayout(3);
         else if (r0 == "DDBBB" || r0 == "BDDBB" || r0 == "BBDDB" || r0 == "BBBDD")
             totalCoins += reels[0].symbols[1].CheckPayout(2);
         else
             totalCoins += reels[0].symbols[1].CheckPayout(1);

         if (r0 == "CCCCC")
             totalCoins += reels[0].symbols[1].CheckPayout(4);
         else if (r0 == "ECCCC" || r0 == "CECCC" || r0 == "CCECC" || r0 == "CCCEC" || r0 == "CCCCE")
             totalCoins += reels[0].symbols[1].CheckPayout(3);
         else if (r0 == "EECCC" || r0 == "CEECC" || r0 == "CCEEC" || r0 == "CCCEE")
             totalCoins += reels[0].symbols[1].CheckPayout(2);
         else
             totalCoins += reels[0].symbols[1].CheckPayout(1);*/
    }
}
