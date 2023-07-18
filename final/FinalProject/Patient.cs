public class Patient{
    
    private string _name;
    private int _patientNumber;
    private int _contactNumber;
    private string _ailment;

    Rooms _room;

    public Patient(string name, int contactNumber, string ailment){
        _name=name;
        _contactNumber=contactNumber;
        _ailment=ailment;
        _patientNumber=0;
    }

    public int GetPatientNumber(){
        return _patientNumber;
    }
    public void SetPatientNumber(int patientNumber){
        _patientNumber=patientNumber;
    }
    
}