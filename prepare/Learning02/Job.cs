public class Job{
    public string _companyName;
    public string _jobTitle;
    public double _startYear;
    public double _endYear;


    public string DisplayJob(){
        return ($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
    



}