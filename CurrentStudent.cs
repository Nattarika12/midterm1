public class CurrentStudent: Person{
    private int studentID;
    private string are_you_an_administrator;
    private string email;
    private int password;

    public CurrentStudent(string namefrefix, string name, string lastname,int studentID, int age,string allergy, string religion, string are_you_an_administrator, string email,
    int password) : base(namefrefix, name, lastname, age, allergy, religion) {
        this.studentID = studentID;
        this.are_you_an_administrator = are_you_an_administrator;
        this.email = email;
        this.password = password;
    }
} 