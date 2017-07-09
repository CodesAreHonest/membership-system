using System;
using System.Windows.Forms;
namespace membership_system
{
    class Fee
    {
        private string memberName;
        private decimal fees_required2pay;
        private decimal fees_paid;
        private decimal fees_left;
        private Boolean paid = false; 

        public Fee()
        {

        }

        public void setMemberName(string memberName)
        {
            this.memberName = memberName;
        }

        public void setFeesLeft(decimal fees_left)
        {
            this.fees_left = decimal.Round(fees_left, 2, MidpointRounding.AwayFromZero);
        }

        public void setFeesRequiredToPay(decimal fees_required2pay)
        {
            this.fees_required2pay = decimal.Round(fees_required2pay, 2, MidpointRounding.AwayFromZero);
        }

        public void setFeesPaid(decimal fees_paid)
        {
            this.fees_paid = decimal.Round(fees_paid, 2, MidpointRounding.AwayFromZero);
        }

        public string getMemberName()
        {
            return memberName;
        }

        public decimal getFeesLeft()
        {
            return decimal.Round(fees_left, 2, MidpointRounding.AwayFromZero);
        }

        public decimal calculateRemainingFees()
        {
            decimal remainingFees = fees_required2pay - fees_paid;

            // ensure wont have negative
            if(remainingFees < 0)
            {
                remainingFees = 0;
            }

            return decimal.Round(remainingFees, 2, MidpointRounding.AwayFromZero);
        }

        public int calculatePaidStatus()
        {
            // extra validation for safety purpose
            paid = (getFeesLeft().Equals(0) || calculateRemainingFees().Equals(0)) ? true : false;

            int paidBit = (paid) ? 1 : 0;
            return paidBit;
        }

        public void setPaidStatus(Boolean paid)
        {
            this.paid = paid;
        }

    }
}
