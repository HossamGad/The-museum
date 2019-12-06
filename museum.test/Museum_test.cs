using System;
using Xunit;
using System.Collections.Generic;

namespace Museum_test
{
    public class test
    {
        [TestMethod]
        public void ArtListLength()
        {
        //arrange
        
        List<A_List> MyList = new List<A_List>();

        //act
         int lenght = MyList.Count;

        //assert
         Assert.Equal(14, lenght);
        }


        [TestMethod]
        public void LastTest()
        {
        //arrange
        List<A_List> MyList = new List<A_List>();
        

        //act
        string nameOfitems = MyList[3].itemName;

        //assert
         Assert.Equal("Art1", nameOfitems);
        }



    }
}
