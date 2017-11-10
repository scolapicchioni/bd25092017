using System;
using System.Collections.Generic;
using System.Text;

namespace H09_LabMocking01
{
    public class LibraryManager
    {
        private ILibraryStore _store;
        public LibraryManager(ILibraryStore store) {
            _store = store;
        }
        public double CalculateMemberShipCost(int memberId) {
            double membershipCost = 0;
            LibraryMember member = _store.GetMember(memberId);
            membershipCost = 10 + member.MaximumBooks * 0.5;
            return membershipCost;
        }
    }
}
