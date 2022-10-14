public class Student {
    private string namefrefix;
    private string name;
    private string lastname;
    private int age;
    private string level_of_education;
    private string allergy;
    private string religion;
    private string school;
    public Student(string namefrefix, string name, string lastname, int age, string level_of_education,
    string allergy, string religion, string school){
        this.namefrefix = namefrefix;
        this.name = name;
        this.lastname = lastname;
        this.age = age;
        this.level_of_education = level_of_education;
        this.allergy = allergy;
        this.religion = religion;
        this.school = school;
    }
    public string GetNameFrefix(){
        return this.namefrefix;
    }
    public string GetName(){
        return this.name;
    }
    public string GetLastName(){
        return this.lastname;
    }
    public int GetAge(){
        return this.age;
    }
    public string GetLevelOfEducation(){
        return this.level_of_education;
    }
    public string GetAllergy(){
        return this.allergy;
    }
    public string GetSReligion(){
        return this.religion;
    }
    public string GetSchool(){
        return this.school;
    }
}