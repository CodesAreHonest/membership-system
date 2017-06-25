using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace membership_system
{
    class Member
    {
        private string name;
        private int handphone;
        private string email;
        private string gender;
        private string intakecode;

        public Member(string name, int handphone, string email, string gender, string intakecode)
        {
            this.name = name;
            this.handphone = handphone;
            this.email = email;
            this.gender = gender;
            this.intakecode = intakecode;
        }

        public string getName()
        {
            return name;
        }

        public int getHP()
        {
            return handphone;
        }

        public string getEmail()
        {
            return email;
        }

        public string getGender()
        {
            return gender;
        }

        public string getIntakeCode()
        {
            return intakecode;
        }

    }
}
