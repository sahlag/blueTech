using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backondor.Models
{
   public class Room
    {

        
        #region "Properties"
        public int RoomID { get; set;}
        public String RoomName { get; set; }

        public int NumberOfPlayer { get; set; }

        public int RoundNumber { get; set; }
        public int RoundNumberMax { get; set; }

        public int RoomScore { get; set; }

        public int NumberOfChoosenCategories { get; set; }
         #endregion
 
        #region "Methods"

        /// <summary>
        /// The method for creating the room 
        /// </summary>
        public void CreatRoom ()
        {

        }


        /// <summary>
        /// The method for loading the data  
        public void LoadRoomRessources ()
        {



        }


        /// <summary>
        /// The method for displaying the score of the game 
        /// </summary>
        public void DisplayScoreRoom ()

        {



        }




        #endregion
    }
}
