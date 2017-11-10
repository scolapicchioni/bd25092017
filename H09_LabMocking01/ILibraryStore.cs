namespace H09_LabMocking01 {
    public interface ILibraryStore {
        void AddMember(LibraryMember member);
        void DeleteMember(int memberId);
        LibraryMember GetMember(int memberId);
        void UpdateMember(int memberId, LibraryMember member);
    }
}