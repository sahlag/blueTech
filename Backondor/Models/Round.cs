using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backondor.Models
{
    public class Round
    {
        #region "Properties"
        public int RoundTime { set; get; }
        public int RoundScore { set; get; }
        public string RandomLetter { set; get; }

        #endregion

        #region "Methods"

        /// <summary>
        /// Start a Round
        /// </summary>
        public void CreateRound()
        {

        }

        /// <summary>
        /// Display the Page with category and such
        /// </summary>
        public void DisplayRound()
        {

        }

        /// <summary>
        /// Choose a letter randomly and control to not have the same letter twice
        /// </summary>
        public void ChooseRandomLetter()
        {

        }

        /// <summary>
        /// Display the score for the round
        /// </summary>
        public void DisplayScoreRound()
        {

        }

        /// <summary>
        /// Check players answer comparing with DB
        /// </summary>
        public void CheckSubmittedWord()
        {

        }



        #endregion

    }
}
