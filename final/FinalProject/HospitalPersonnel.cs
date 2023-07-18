public abstract class HospitalPersonnel{
    private string _name;
    private int _id;
    private string _jobTitle;

    public HospitalPersonnel(string name, int id, string jobTitle){
        _name=name;
        _id=id;
        _jobTitle=jobTitle;
    }

    public abstract void AssignPersonnel();
    
}