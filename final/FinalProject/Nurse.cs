public class Nurse:HospitalPersonnel{
            public Nurse(string name, int id, string jobTitle):base(name, id, jobTitle){

            }


    public override void AssignPersonnel(){
        Console.WriteLine("Nurse assigned to patient");  
    }
}
