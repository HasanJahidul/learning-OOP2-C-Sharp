using System;
using System.Collections.Generic;
using System.Text;

namespace FinalLabTask1
{
    class ClubCommittee
    {
        protected static Member[] clubMember = new Member[5];
        
        protected int  index = 0;
        internal void AddMember (Member mem)
        {
            
            clubMember[index] = mem;
            index++;
        }
        internal void GetAllDetails()
        {
            int count = 0;
            while (count <clubMember.Length)
            {
               if (clubMember[count]!=null)
                {
                    clubMember[count].GetAllDetails();
                }
                count++;
            }

        }

    }
}
