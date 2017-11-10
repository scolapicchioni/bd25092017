using System;
using System.Collections.Generic;
using System.Text;

namespace H09_LabMocking01
{
    public class LibraryStore : ILibraryStore {
        public LibraryMember GetMember(int memberId) {
            throw new NotImplementedException();
        }

        public void AddMember(LibraryMember member) {
            throw new NotImplementedException();
        }

        public void DeleteMember(int memberId) {
            throw new NotImplementedException();
        }
        public void UpdateMember(int memberId, LibraryMember member) {
            throw new NotImplementedException();
        }
    }
}
