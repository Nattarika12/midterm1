public class Person{
    private string namefrefix;
    private string name;
    private string lastname;
    private int age;
    private string allergy;
    private string religion;

    public Person(string namefrefix, string name, string lastname,int age,string allergy, string religion){
        this.namefrefix = namefrefix;
        this.name = name;
        this.lastname = lastname;
        this.age = age;
        this.allergy = allergy;
        this.religion = religion;
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
    public string GetAllergy(){
        return this.allergy;
    }
    public string GetReligion(){
        return this.religion;
    }
}