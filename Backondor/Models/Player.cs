using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backondor.Models
{
    public class Player
    {
        #region "Properties"
        public int PlayerID { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pseudo{ get; set; }
        public string Avatar { get; set; }
        public string EmailAddress { get; set; }

        #endregion


        #region "Methods"
        /// <summary>
        /// let player to sign in with a pseudo
        /// </summary>
        public void SignIn()
        {

        }

        /// <summary>
        /// the player needs to choose a role 
        /// </summary>
        public void ChooseRole()
        {

        }
        #endregion

    }
}
