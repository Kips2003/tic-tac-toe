using System;

namespace TicTacToe{
    public class MyProgram{
        public static void CheckForWin(char[] ch, bool winQ){
            bool? winerOrLoser = null;
            if(ch[0] == ch[1] && ch[1] == ch[2]){
                if(ch[0] == 'X') winerOrLoser = true;
                else winerOrLoser = false;
            }
            if(ch[3] == ch[4] && ch[4] == ch[5]){
                if(ch[3] == 'X') winerOrLoser = true;
                else winerOrLoser = false;
            }
            if(ch[6] == ch[7] && ch[7] == ch[8]){
                if(ch[6] == 'X') winerOrLoser = true;
                else winerOrLoser = false;
            }
            if(ch[0] == ch[4] && ch[4] == ch[8]){
                if(ch[0] == 'X') winerOrLoser = true;
                else winerOrLoser = false;
            }
            if(ch[2] == ch[4] && ch[4] == ch[6]){
                if(ch[2] == 'X') winerOrLoser = true;
                else winerOrLoser = false;
            }
            if(ch[0] == ch[3] && ch[3] == ch[6]){
                if(ch[0] == 'X') winerOrLoser = true;
                else winerOrLoser = false;
            }
            if(ch[1] == ch[4] && ch[4] == ch[7]){
                if(ch[1] == 'X') winerOrLoser = true;
                else winerOrLoser = false;
            }
            if(ch[2] == ch[5] && ch[1] == ch[8]){
                if(ch[2] == 'X') winerOrLoser = true;
                else winerOrLoser = false;
            }



            if(winerOrLoser == true){
                System.Console.WriteLine("Congratulations Player 1!! you won the game!!");
                winQ = false;
            }
            else if(winerOrLoser == false){
                System.Console.WriteLine("Congratulations Player 2!! you won the game!!");
                winQ = false;
            }
        }

        public static bool KeyCheck(char ch, char[]  c, char player){
            for(int i = 0; i < c.Length; i++ ){
                if(c[i] == ch){
                    c[i] = player;
                    return true;
                }
                else continue;
            }
            return false;
        }


        public static void Main(string[] args){
            
            
            System.Console.WriteLine(
                "|||||||| Welcome ||||||||\n||||||||    TO   |||||||| \n|||||| Tic Tac Toe ||||||"
            );      


            char[] nums = new char[9]{'1','2','3','4','5','6','7','8','9'};
            char playerX = 'X';
            char playerO = 'O';
            int turnNumber = 0;
            bool winq = true;
            
            System.Console.WriteLine($"{nums[0]}|{nums[1]}|{nums[2]}\n_____\n{nums[3]}|{nums[4]}|{nums[5]}\n_____\n{nums[6]}|{nums[7]}|{nums[8]}");

            System.Console.WriteLine();
            while(winq){

                ConsoleKeyInfo key;
                char keychar;

                while(winq){
                    System.Console.WriteLine("Player 1 \nchoose the number you want to Put the X in _");
                    key = Console.ReadKey();
                    keychar = key.KeyChar;
                    System.Console.WriteLine();
                    
                    if(!KeyCheck(keychar,nums,playerX)){
                        System.Console.WriteLine("wrong input please try again!!");
                    }
                    else{
                        System.Console.WriteLine($"{nums[0]}|{nums[1]}|{nums[2]}\n_____\n{nums[3]}|{nums[4]}|{nums[5]}\n_____\n{nums[6]}|{nums[7]}|{nums[8]}");
                        turnNumber++;
                        if(turnNumber >2){
                            CheckForWin(nums,winq);
                        }
                        break;
                    };
                }

                while(winq){
                    
                    System.Console.WriteLine("Player 2 \nchoose the number you want to py the O in _");
                    key = Console.ReadKey();
                    keychar = key.KeyChar;
                    System.Console.WriteLine();
                    
                    if(!KeyCheck(keychar,nums,playerO)){
                        System.Console.WriteLine("wrong input please try again!!");
                    }
                    else{
                        System.Console.WriteLine($"{nums[0]}|{nums[1]}|{nums[2]}\n_____\n{nums[3]}|{nums[4]}|{nums[5]}\n_____\n{nums[6]}|{nums[7]}|{nums[8]}");
                        turnNumber++;
                        if(turnNumber >2){
                            CheckForWin(nums,winq);
                        }
                        break;
                    }
                }    
            
            }
            
        }
    }
}