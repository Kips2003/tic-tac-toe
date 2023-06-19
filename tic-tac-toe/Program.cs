using System;

namespace TicTacToe{
    public class MyProgram{
        //CheckForWin metodi romelic
        //monacemad igebs charebis masivs
        //da ukan abrunebs tu romelma moigo
        //1 nishnavs X'is mogebas
        //0 nishanavs O'is mogebas
        //xolo -1 nishnavs fres
        public static int CheckForWin(char[] ch){
            int winerOrLoser = -1;
            if(ch[0] == ch[1] && ch[1] == ch[2]){
                if(ch[0] == 'X') winerOrLoser = 1;
                else winerOrLoser = 0;
            }
            if(ch[3] == ch[4] && ch[4] == ch[5]){
                if(ch[3] == 'X') winerOrLoser = 1;
                else winerOrLoser = 0;
            }
            if(ch[6] == ch[7] && ch[7] == ch[8]){
                if(ch[6] == 'X') winerOrLoser = 1;
                else winerOrLoser = 0;
            }
            if(ch[0] == ch[4] && ch[4] == ch[8]){
                if(ch[0] == 'X') winerOrLoser = 1;
                else winerOrLoser = 0;
            }
            if(ch[2] == ch[4] && ch[4] == ch[6]){
                if(ch[2] == 'X') winerOrLoser = 1;
                else winerOrLoser = 0;
            }
            if(ch[0] == ch[3] && ch[3] == ch[6]){
                if(ch[0] == 'X') winerOrLoser = 1;
                else winerOrLoser = 0;
            }
            if(ch[1] == ch[4] && ch[4] == ch[7]){
                if(ch[1] == 'X') winerOrLoser = 1;
                else winerOrLoser = 0;
            }
            if(ch[2] == ch[5] && ch[1] == ch[8]){
                if(ch[2] == 'X') winerOrLoser = 1;
                else winerOrLoser = 0;
            }

            return winerOrLoser;
            
        }



        //KeyCheck metodi romelic monacemad igebs
        //chars klaviaturidan shemotanili gilaks
        //romelsac mowmdeba aris tu ara 1dan 9is chatvlit
        //an aris tu ara dakavebuli mocemuli adgili
        //tu dakavebuli ar aris, charebis masivshi
        //ricxvi chanacvldeba motamashis simbolit
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
            
            //misalmeba motamasheebtan
            System.Console.WriteLine(
                "|||||||| Welcome ||||||||\n||||||||    TO   |||||||| \n|||||| Tic Tac Toe ||||||"
            );      

            //monacemebi romlis sashilebitac xerxdeba tamashi
            //charebis masivi ujrebis adgilistvis
            //playerX da playerO motamashis simboloebistvis
            // da turn number natamshebis svlebis dasatvlelad
            char[] nums = new char[9]{'1','2','3','4','5','6','7','8','9'};
            char playerX = 'X';
            char playerO = 'O';
            int turnNumber = 0;
            
            //satamsho magidis sawyisi forma
            System.Console.WriteLine($"{nums[0]}|{nums[1]}|{nums[2]}\n_____\n{nums[3]}|{nums[4]}|{nums[5]}\n_____\n{nums[6]}|{nums[7]}|{nums[8]}");

            System.Console.WriteLine();

            while(true){
                
                ConsoleKeyInfo key;
                char keychar;

                //loopi imistvis rom gavigod
                //sworia tu ara shetanili monacemi
                //damtavrda tu ara tamashi fred
                //damtavrda tu ara tamashi pirveli motamashis sasargeblod
                //tu ubralod grdzeldeba tamashi
                while(true){
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
                            if( CheckForWin(nums)==1){
                                System.Console.WriteLine("Congratulations Player 1!! you won the game!!");
                                return;
                            }
                            else if(turnNumber == 9 && CheckForWin(nums) == -1){
                                System.Console.WriteLine("It's a tie!! Thank you for Playing!!");
                                return;
                            }
                        }
                        break;
                    };
                }
                
                //meore loopi romelic gagvagebiebs
                //meore motamashis mier shemotanili simbolos
                //aris tu ara es simbolo misagebi
                //moigo tu ara meore motamashem
                //da tu grdzeldeba tamashi
                while(true){
                    
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
                            if( CheckForWin(nums)==0){
                                System.Console.WriteLine("Congratulations Player 2!! you won the game!!");
                                return;
                            }
                        }
                        break;
                    }
                }    
            
            }
            
        }
    }
}