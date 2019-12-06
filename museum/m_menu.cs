using System;
using System.Collections.Generic;

namespace museum
{
    class Menu
    {  
        List<R_List> My_places = new List<R_List>();
        List<A_List> My_museum = new List<A_List>();

        int choice;
        public void museum_Menu()

        {   //Making list with ArtItems 
           
            A_List Art = new A_List();
            Art.ArtTotal(My_museum);


            //Making list with All rooms      
            R_List listRooms = new R_List();
            listRooms.Rooms(My_places);

            int roomId = 0;          //setting location to "entry"    
            
            Console.Clear();
            Console.WriteLine("-------------------------------- Welcome To The Museum--------------------------------------\n"); 
            Console.WriteLine("\t¤ you can walk between different rooms and consider a variety of beautiful photos.");
            //Console.WriteLine("\t ");
            Console.WriteLine("\t¤ In each room you get information about where you are and ");
            Console.WriteLine("\t  which rooms are open from that room. ");
            Console.WriteLine("\t¤ In each room you can choose a new one to move on to.\n");

            Console.WriteLine($"You are in the lobby\n");            
            

            do
            {   string roomNow = My_places[roomId].roomName;
                Console.WriteLine("Please select:");
                Console.WriteLine($"1) Discover all the arts in the {roomNow} ");
                Console.WriteLine("2) locate the connecting rooms");
                Console.WriteLine("9) Exit the program");

                int.TryParse(Console.ReadLine(), out choice);       
                Console.Clear(); 
                          // Switch sats
                switch(choice) 
                {    
                    case 1:
                             
                    Console.WriteLine($"The art in the {roomNow} is:\n");
                    foreach (var art in My_museum) 
                    { 
                        if(art.GetRoom == roomId) 
                        {Console.WriteLine(art.item_Name, art.artist);
                        } 
                    }
                    Console.WriteLine();
                    break;                    

                    case 2:                     
                    Console.WriteLine($"All the connecting rooms to {roomNow} are:\n");
                    foreach (var arts in My_places) 

                        {
                            if(arts.roomID == roomId) 

                            {   
                            int first_Room = arts.connectedRoom1;
                            string nameFirst= My_places[first_Room].roomName;
                            Console.WriteLine($"{nameFirst} - press {arts.connectedRoom1} to enter");
                            if(arts.connectedRoom2 ==9){break;}

                            int second_Room = arts.connectedRoom2;
                            string nameSecond= My_places[second_Room].roomName;
                            Console.WriteLine($"{nameSecond} - press {arts.connectedRoom2} to enter");
                            if(arts.connectedRoom3 ==9){break;}

                            int third_Room = arts.connectedRoom3;
                            string nameThird= My_places[third_Room].roomName;
                            Console.WriteLine($"{nameThird} - press {arts.connectedRoom3} to enter");   
                            if(arts.connectedRoom4 ==9){break;}

                            int fourth_Room = arts.connectedRoom4;
                            string nameFourth= My_places[fourth_Room].roomName;
                            Console.WriteLine($"{nameFourth} - press {arts.connectedRoom4} to enter");  

                                Console.WriteLine($"{arts.connectedRoom4}");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Write your next destination\n");
                        
                        try{
                        roomId =Int32.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Wrong choice!");
                        }                                               
                         if (roomId == 9)
                            {Console.WriteLine("Try again");
                            } 
                            Console.Clear();
                                       
                    break;


                    case 9:
                    Console.WriteLine("Exit");
                    roomId =9;
                    break;

                    default:
                    Console.WriteLine("Wrong choice. Try again");
                    Console.ReadKey();
                    Console.Clear();
                    
                    break;

                }

            }while(roomId != 9);

        }
    }
}