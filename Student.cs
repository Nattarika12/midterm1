public class Student: Person {
    private string level_of_education;
    private string school;
    public Student(string namefrefix, string name, string lastname, int age, string level_of_education,
    string allergy, string religion, string school) : base(namefrefix, name, lastname, age, allergy, religion) {
        this.level_of_education = level_of_education;
        this.school = school;
    }
}