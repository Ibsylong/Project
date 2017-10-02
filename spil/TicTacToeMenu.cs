using System;
using System.Threading;

namespace spil
{
    public class TicTacToeMenu
    {
        TicTacToe ticTacToe {get; set; }
 
        bool player1turn;
        //Show()-----------------------------------------------------------------------------
        public void Show()
        {
            bool running = true;            
            string choice = "";
            do
            {
                ShowMenu();
                choice = GetUserChoise();
                switch (choice)
                {
                    case "1": DoActionFor1(); break;
                    case "2": DoActionFor2(); break;
                    case "3": DoActionFor3(); break;
                    case "0": running = false; break;
                    default : ShowMenuSelectionErroe(); break;
                }
            } while (running);
        }
        //ShowMenu()--------------------------------------------------------------------------
        private void ShowMenu()
        {
            Console.Clear();
            if (ticTacToe != null)
            {
                Console.WriteLine(ticTacToe.GetGameBoardView());
            }
            Console.WriteLine("tic tac toe");
            Console.WriteLine();
            Console.WriteLine("1. Opret nyt spil");
            Console.WriteLine("2. Set en brik");
            Console.WriteLine("3. Flyt en brik");
            Console.WriteLine();
            Console.WriteLine("0. exit");
            if (ticTacToe != null) {
                if (ticTacToe.Validate() != ' ') {
                    Console.WriteLine("the Winner is:"+ "" + ticTacToe.Validate());
                    Console.ReadLine();
                    player1turn = true;
                    DoActionFor1();
                    ShowMenu();
                }
                   
            }
        }
        //GetUserChoise-----------------------------------------------------------------------
        private string GetUserChoise()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }
        //ShowMenuSelectionErroe--------------------------------------------------------------
        private void ShowMenuSelectionErroe()
        {
            Console.WriteLine("Ugyldigt valg.");
            Console.ReadLine();
        }
        //DoActionFor1------------------------------------------------------------------------
        private void DoActionFor1()
        {
            //Console.WriteLine("skriv koden til at opret nyt spil");
            ticTacToe = new TicTacToe();
            player1turn = true;
            
            //Console.ReadLine();
        }
        //DoActionFor2------------------------------------------------------------------------
        private void DoActionFor2()
        {
           
            string input = "";
            int X = 0;
            int O = 0;
            //3 brick check-------------------------------------------------------------------
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    if (ticTacToe.GameBoard[i, j] == 'X') {
                        X++;
                    }
                    if (ticTacToe.GameBoard[i, j] == 'O') {
                        O++;
                    }
                }
            }
            //player 1 place brick------------------------------------------------------------
            if (player1turn)
            {
                Console.WriteLine("Player 1's turn");
                if (X == 3)
                {
                    Console.WriteLine("Player 1 has reached maximum");
                    DoActionFor3();
                }
                else
                {
                    switch (input = Console.ReadLine())
                    {
                        case "1":
                            if (ticTacToe.GameBoard[0, 0] == ' ')
                            {
                                ticTacToe.Brick(0, 0, 'X');
                                player1turn = false;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "2":
                            if (ticTacToe.GameBoard[1, 0] == ' ')
                            {
                                ticTacToe.Brick(1, 0, 'X');
                                player1turn = false;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "3":
                            if (ticTacToe.GameBoard[2, 0] == ' ')
                            {
                                ticTacToe.Brick(2, 0, 'X');
                                player1turn = false;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "4":
                            if (ticTacToe.GameBoard[0, 1] == ' ')
                            {
                                ticTacToe.Brick(0, 1, 'X');
                                player1turn = false;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "5":
                            if (ticTacToe.GameBoard[1, 1] == ' ')
                            {
                                ticTacToe.Brick(1, 1, 'X');
                                player1turn = false;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "6":
                            if (ticTacToe.GameBoard[2, 1] == ' ')
                            {
                                ticTacToe.Brick(2, 1, 'X');
                                player1turn = false;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "7":
                            if (ticTacToe.GameBoard[0, 2] == ' ')
                            {
                                ticTacToe.Brick(0, 2, 'X');
                                player1turn = false;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "8":
                            if (ticTacToe.GameBoard[1, 2] == ' ')
                            {
                                ticTacToe.Brick(1, 2, 'X');
                                player1turn = false;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "9":
                            if (ticTacToe.GameBoard[2, 2] == ' ')
                            {
                                ticTacToe.Brick(2, 2, 'X');
                                player1turn = false;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid key");
                            Console.ReadLine();
                            break;
                    }
                }

            }
            //player 2 place brick------------------------------------------------------------
            else {
                Console.WriteLine("Player 2's turn");
                if (O == 3)
                {
                    Console.WriteLine("Player 2 has reached maximum");
                    DoActionFor3();
                }

                else {
                      
                    switch (input = Console.ReadLine())
                    {
                        case "1":
                            if (ticTacToe.GameBoard[0, 0] == ' ')
                            {
                                ticTacToe.Brick(0, 0, 'O');
                                player1turn = true;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "2":
                            if (ticTacToe.GameBoard[1, 0] == ' ')
                            {
                                ticTacToe.Brick(1, 0, 'O');
                                player1turn = true;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "3":
                            if (ticTacToe.GameBoard[2, 0] == ' ')
                            {
                                ticTacToe.Brick(2, 0, 'O');
                                player1turn = true;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "4":
                            if (ticTacToe.GameBoard[0, 1] == ' ')
                            {
                                ticTacToe.Brick(0, 1, 'O');
                                player1turn = true;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "5":
                            if (ticTacToe.GameBoard[1, 1] == ' ')
                            {
                                ticTacToe.Brick(1, 1, 'O');
                                player1turn = true;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "6":
                            if (ticTacToe.GameBoard[2, 1] == ' ')
                            {
                                ticTacToe.Brick(2, 1, 'O');
                                player1turn = true;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "7":
                            if (ticTacToe.GameBoard[0, 2] == ' ')
                            {
                                ticTacToe.Brick(0, 2, 'O');
                                player1turn = true;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "8":
                            if (ticTacToe.GameBoard[1, 2] == ' ')
                            {
                                ticTacToe.Brick(1, 2, 'O');
                                player1turn = true;
                                ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Position already taken");
                                Console.ReadLine();
                            }
                            break;

                        case "9":
                                if (ticTacToe.GameBoard[2, 2] == ' ')
                                {
                                    ticTacToe.Brick(2, 2, 'O');
                                    player1turn = true;
                                    ShowMenu();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Position already taken");
                                    Console.ReadLine();
                            }
                                break;
                            

                        default:
                            Console.WriteLine("Invalid key");
                            Console.ReadLine();
                            break;
                    }
                }
            }
        }
        //DoActionFor3------------------------------------------------------------------------
        private void DoActionFor3()
        {
            
            Console.WriteLine("Choose brick to move");
            string input = "";
            string placeinput = "";
            //player 1 move a brick-----------------------------------------------------------
            if (player1turn)
            {
                Console.WriteLine("Player 1 choose brick to move");
                switch (input = Console.ReadLine())
                {
                    //player 1 move brick on 1------------------------------------------------
                    case "1":
                        
                        if (ticTacToe.GameBoard[0, 0] == 'X')
                        {
                            ticTacToe.Remove(0, 0);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place");
                                           Console.ReadLine();
                                    }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                    // player 1 move brick on 2-----------------------------------------------
                    case "2":
                        
                        if (ticTacToe.GameBoard[1, 0] == 'X')
                        {
                            ticTacToe.Remove(1, 0);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 1 move brick on 3--------------------------------------------
                    case "3":
                       
                        if (ticTacToe.GameBoard[2, 0] == 'X')
                        {
                            ticTacToe.Remove(2, 0);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 1 move brick on 4--------------------------------------------
                    case "4":
                        
                        if (ticTacToe.GameBoard[0, 1] == 'X')
                        {
                            ticTacToe.Remove(0, 1);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 1 move brick on 5--------------------------------------------
                    case "5":
                        
                        if (ticTacToe.GameBoard[1, 1] == 'X')
                        {
                            ticTacToe.Remove(1, 1);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 1 move brick on 6------------------------------------------
                    case "6":
                        
                        if (ticTacToe.GameBoard[2, 1] == 'X')
                        {
                            ticTacToe.Remove(2, 1);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 1 move brick on 7--------------------------------------------
                    case "7":
                        
                        if (ticTacToe.GameBoard[0, 2] == 'X')
                        {
                            ticTacToe.Remove(0, 2);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 1 move brick on 8--------------------------------------------
                    case "8":
                        
                        if (ticTacToe.GameBoard[1, 2] == 'X')
                        {
                            ticTacToe.Remove(1, 2);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 1 move brick on 9--------------------------------------------
                    case "9":
                        
                        if (ticTacToe.GameBoard[2, 2] == 'X')
                        {
                            ticTacToe.Remove(2, 2);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'X');
                                        player1turn = false;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                }
            }
            //player 2 move a brick-----------------------------------------------------------
            else {
                Console.WriteLine("Player 2 choose brick to move");
                switch (input = Console.ReadLine())
                {
                    //player 2 move brick on 1------------------------------------------------
                    case "1":
                        
                        if (ticTacToe.GameBoard[0, 0] == 'O')
                        {
                            ticTacToe.Remove(0, 0);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 2 move brick on 2--------------------------------------------
                    case "2":
                        
                        if (ticTacToe.GameBoard[1, 0] == 'O')
                        {
                            ticTacToe.Remove(1, 0);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 2 mve brick on 3---------------------------------------------
                    case "3":
                        
                        if (ticTacToe.GameBoard[2, 0] == 'O')
                        {
                            ticTacToe.Remove(2, 0);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 2 move brick on 4--------------------------------------------
                    case "4":
                        
                        if (ticTacToe.GameBoard[0, 1] == 'O')
                        {
                            ticTacToe.Remove(0, 1);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 2 move brick on 5--------------------------------------------
                    case "5":
                        
                        if (ticTacToe.GameBoard[1, 1] == 'O')
                        {
                            ticTacToe.Remove(1, 1);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 2 move on brick 6--------------------------------------------
                    case "6":
                        
                        if (ticTacToe.GameBoard[2, 1] == 'O')
                        {
                            ticTacToe.Remove(2, 1);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 2 move brick on 7--------------------------------------------
                    case "7":
                        
                        if (ticTacToe.GameBoard[0, 2] == 'O')
                        {
                            ticTacToe.Remove(0, 2);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 2 move brick on 8--------------------------------------------
                    case "8":
                        
                        if (ticTacToe.GameBoard[1, 2] == 'O')
                        {
                            ticTacToe.Remove(1, 2);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "9":
                                    if (ticTacToe.GameBoard[2, 2] == ' ')
                                    {
                                        ticTacToe.Brick(2, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;
                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                        //player 2 move brick on 9--------------------------------------------
                    case "9":
                        
                        if (ticTacToe.GameBoard[2, 2] == 'O')
                        {
                            ticTacToe.Remove(2, 2);
                            Console.WriteLine("Choose place");
                            switch (placeinput = Console.ReadLine())
                            {

                                case "1":
                                    if (ticTacToe.GameBoard[0, 0] == ' ')
                                    {

                                        ticTacToe.Brick(0, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "2":
                                    if (ticTacToe.GameBoard[1, 0] == ' ')
                                    {

                                        ticTacToe.Brick(1, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "3":
                                    if (ticTacToe.GameBoard[2, 0] == ' ')
                                    {
                                        ticTacToe.Brick(2, 0, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "4":
                                    if (ticTacToe.GameBoard[0, 1] == ' ')
                                    {
                                        ticTacToe.Brick(0, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "5":
                                    if (ticTacToe.GameBoard[1, 1] == ' ')
                                    {
                                        ticTacToe.Brick(1, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "6":
                                    if (ticTacToe.GameBoard[2, 1] == ' ')
                                    {
                                        ticTacToe.Brick(2, 1, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "7":
                                    if (ticTacToe.GameBoard[0, 2] == ' ')
                                    {
                                        ticTacToe.Brick(0, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                                case "8":
                                    if (ticTacToe.GameBoard[1, 2] == ' ')
                                    {
                                        ticTacToe.Brick(1, 2, 'O');
                                        player1turn = true;
                                        ShowMenu();
                                        break;
                                    }
                                    else { Console.WriteLine("Invalid place"); Console.ReadLine(); }
                                    break;

                            }
                        }
                        else { Console.WriteLine("Invalid brick"); Console.ReadLine(); }
                        break;
                }
            }
            
        }

    }
}
    