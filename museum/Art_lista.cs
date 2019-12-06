
using System;
using System.Collections.Generic;

namespace museum
{
    public class A_List
    {
        public string item_Name, artist; 
        public int GetRoom;

        public void SetArt(string ItemName, string Artist, int ID)
        {
            this.item_Name = ItemName;
            this.artist = Artist;
            this.GetRoom = ID;

        }

        public List<A_List> ArtTotal(List<A_List> My_art_List)
        {   

            //Lobby
            var ItemZero = new A_List();
            string ItemName0 = "There is nothing here in this room", Artist0 =  "";
            int ID0 = 0; 
            ItemZero.SetArt(ItemName0, Artist0, ID0);
            My_art_List.Add(ItemZero);  

            //corridor 
            var ItemC = new A_List();
            string ItemNameC = "There is nothing here in this room", ArtistC =  "";
            int IDC = 1; 
            ItemC.SetArt(ItemNameC, ArtistC, IDC);
            My_art_List.Add(ItemC);  

            //Green room  
            var ItemOne = new A_List();
            string ItemName = "Art1", Artist =  "Mona Lisa";
            int ID = 2; 
            ItemOne.SetArt(ItemName, Artist, ID);
            My_art_List.Add(ItemOne);  
            
            var Item2 = new A_List();
            string ItemName2 = "Art2", Artist2 =  "Mona Lisa";
            int ID2 = 2; 
            Item2.SetArt(ItemName2, Artist2, ID2);
            My_art_List.Add(Item2);

            //Red room
            var Item3 = new A_List();
            string ItemName3 = "Art3", Artist3 =  "Mona Lisa";
            int ID3 = 3; 
            Item3.SetArt(ItemName3, Artist3, ID3);
            My_art_List.Add(Item3);

            var Item4 = new A_List();
            string ItemName4 = "Art4", Artist4 =  "Mona Lisa";
            int ID4 = 3; 
            Item4.SetArt(ItemName4, Artist4, ID4);
            My_art_List.Add(Item4);

            var Item5 = new A_List();
            string ItemName5 = "Art5", Artist5 =  "Mona Lisa";
            int ID5 = 3; 
            Item5.SetArt(ItemName5, Artist5, ID5);
            My_art_List.Add(Item5);

            //purple room
            var Item6 = new A_List();
            string ItemName6 = "Art6", Artist6 =  "Mona Lisa";
            int ID6 = 4; 
            Item6.SetArt(ItemName6, Artist6, ID6);
            My_art_List.Add(Item6);

            var Item7 = new A_List();
            string ItemName7 = "Art7", Artist7 =  "Mona Lisa";
            int ID7 = 4; 
            Item7.SetArt(ItemName7, Artist7, ID7);
            My_art_List.Add(Item7);

            var Item8 = new A_List();
            string ItemName8 = "Art8", Artist8 =  "Mona Lisa";
            int ID8 = 4; 
            Item8.SetArt(ItemName8, Artist8, ID8);
            My_art_List.Add(Item8);

            var Item9 = new A_List();
            string ItemName9 = "Art9", Artist9 =  "Mona Lisa";
            int ID9 = 4; 
            Item9.SetArt(ItemName9, Artist9, ID9);
            My_art_List.Add(Item9);

            //blue room
            var Item10 = new A_List();
            string ItemName10 = "Art10", Artist10 =  "Mona Lisa";
            int ID10 = 5; 
            Item10.SetArt(ItemName10, Artist10, ID10);
            My_art_List.Add(Item10);

            //black room - nothing
            var ItemB = new A_List();
            string ItemNameB = "This room is empty", ArtistB =  "";
            int IDB = 6; 
            ItemB.SetArt(ItemNameB, ArtistB, IDB);
            My_art_List.Add(ItemB);


            //White room
            var Item11 = new A_List();
            string ItemName11 = "Art11", Artist11 =  "Mona Lisa";
            int ID11 = 7; 
            Item11.SetArt(ItemName11, Artist11, ID11);
            My_art_List.Add(Item11);

            return My_art_List;
        }

        
    }
    public class R_List{
        public string roomName; 
        public int roomID, connectedRoom1, connectedRoom2, connectedRoom3, connectedRoom4;

        public void SetRoom(string RoomName, int ConnectedRoom1,int ConnectedRoom2,int ConnectedRoom3,int ConnectedRoom4, int RoomID)
        {
            this.roomName = RoomName;
            this.roomID = RoomID;
            this.connectedRoom1 = ConnectedRoom1;
            this.connectedRoom2 = ConnectedRoom2;
            this.connectedRoom3 = ConnectedRoom3;
            this.connectedRoom4 = ConnectedRoom4;

        }
        public List<R_List> Rooms(List<R_List> MyRooms)
        {
            //Entry  
            var RoomItem = new R_List();
            string RoomName  = "Lobby";            
            int RoomId = 0, 
            ConnectedRoom1 = 1,  
            ConnectedRoom2 = 9,            
            ConnectedRoom3 = 9, 
            ConnectedRoom4 = 9; 

            RoomItem.SetRoom(RoomName, ConnectedRoom1, ConnectedRoom2, ConnectedRoom3,ConnectedRoom4,RoomId);
            MyRooms.Add(RoomItem);

            //Corridor 

            var RoomItem1 = new R_List();
            string RoomName1  = "Hall";            
            int RoomId1 = 1, 
            ConnectedRoom1_1 = 0,  
            ConnectedRoom2_1 = 2,            
            ConnectedRoom3_1 = 9, 
            ConnectedRoom4_1 = 9; 

            RoomItem1.SetRoom(RoomName1, ConnectedRoom1_1, ConnectedRoom2_1, ConnectedRoom3_1,ConnectedRoom4_1,RoomId1);
            MyRooms.Add(RoomItem1);  

            //GreenRoom

            var RoomItem2 = new R_List();
            string RoomName2  = "Green Room";            
            int RoomId2 = 2, 
            ConnectedRoom1_2 = 1,  
            ConnectedRoom2_2 = 3,            
            ConnectedRoom3_2 = 5, 
            ConnectedRoom4_2 = 9; 

            RoomItem2.SetRoom(RoomName2, ConnectedRoom1_2, ConnectedRoom2_2, ConnectedRoom3_2,ConnectedRoom4_2,RoomId2);
            MyRooms.Add(RoomItem2);  

             //Red room

            var RoomItem3 = new R_List();
            string RoomName3  = "Red Room";            
            int RoomId3 = 3, 
            ConnectedRoom1_3 = 1,  
            ConnectedRoom2_3 = 3,            
            ConnectedRoom3_3 = 5, 
            ConnectedRoom4_3 = 9; 

            RoomItem3.SetRoom(RoomName3, ConnectedRoom1_3, ConnectedRoom2_3, ConnectedRoom3_3,ConnectedRoom4_3,RoomId3);
            MyRooms.Add(RoomItem3);

             //Purple room

            var RoomItem4 = new R_List();
            string RoomName4  = "Purple Room";            
            int RoomId4 = 4, 
            ConnectedRoom1_4 = 3,  
            ConnectedRoom2_4 = 5,            
            ConnectedRoom3_4 = 9, 
            ConnectedRoom4_4 = 9; 

            RoomItem4.SetRoom(RoomName4, ConnectedRoom1_4, ConnectedRoom2_4, ConnectedRoom3_4,ConnectedRoom4_4,RoomId4);
            MyRooms.Add(RoomItem4);

            //blue room

            var RoomItem5 = new R_List();
            string RoomName5  = "Blue Room";            
            int RoomId5 = 5, 
            ConnectedRoom1_5 = 2,  
            ConnectedRoom2_5 = 4,            
            ConnectedRoom3_5 = 6, 
            ConnectedRoom4_5 = 7; 

            RoomItem5.SetRoom(RoomName5, ConnectedRoom1_5, ConnectedRoom2_5, ConnectedRoom3_5,ConnectedRoom4_5,RoomId5);
            MyRooms.Add(RoomItem5);

            //black room
            var RoomItem6 = new R_List();
            string RoomName6  = "Black Room";            
            int RoomId6 = 6, 
            ConnectedRoom1_6 = 5,  
            ConnectedRoom2_6 = 9,            
            ConnectedRoom3_6 = 9, 
            ConnectedRoom4_6 = 9; 

            RoomItem6.SetRoom(RoomName6, ConnectedRoom1_6, ConnectedRoom2_6, ConnectedRoom3_6,ConnectedRoom4_6,RoomId6);
            MyRooms.Add(RoomItem6);

            //white room
            var RoomItem7 = new R_List();
            string RoomName7  = "White Room";            
            int RoomId7 = 7, 
            ConnectedRoom1_7 = 5,  
            ConnectedRoom2_7 = 9,            
            ConnectedRoom3_7 = 9, 
            ConnectedRoom4_7 = 9; 

            RoomItem7.SetRoom(RoomName7, ConnectedRoom1_7, ConnectedRoom2_7, ConnectedRoom3_7,ConnectedRoom4_7,RoomId7);
            MyRooms.Add(RoomItem7);
        
        return MyRooms;
        }

    }
}