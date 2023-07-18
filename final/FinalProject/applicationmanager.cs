public class ApplicationManager{

    List<Patient> patientList = new List<Patient>();
    List<Doctor> doctorList = new List<Doctor>();
    List<Nurse> nurseList = new List<Nurse>();

    public void MainMenu(){
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1.Add a new patient");
        Console.WriteLine("2.Add a new employee");
        Console.WriteLine("3.Display all patients");
        Console.WriteLine("4.Checkout Patient");
        Console.WriteLine("5.Save Patient File");
        Console.WriteLine("6.Load Patient File");
        Console.WriteLine("7.Quit");



    }
}