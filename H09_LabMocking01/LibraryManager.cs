using System;
using System.Collections.Generic;
using System.Text;

namespace H09_LabMocking01
{
    public class LibraryManager
    {
        public double CalculateMemberShipCost(int memberId) {
            LibraryStore store = new LibraryStore();
            double membershipCost = 0;
            LibraryMember member = store.GetMember(memberId);
            membershipCost = 10 + member.MaximumBooks * 0.5;
            return membershipCost;
        }
    }
}
