public class Lecturer : Person {
    private string position;
    private string bring_a_car_to_attend_event;
    private int car_registration;
    private string are_you_an_administrator;
    private string email;
    private int password;
    public Lecturer(string namefrefix, string name, string lastname,int studentID, int age,string position, string allergy, string religion, 
    string bring_a_car_to_attend_event, int car_registration, string are_you_an_administrator, string email,
    int password) : base(namefrefix, name, lastname, age, allergy, religion) {
        this.position = position;
        this.bring_a_car_to_attend_event = bring_a_car_to_attend_event;
        this.car_registration = car_registration;
        this.are_you_an_administrator = are_you_an_administrator;
        this.email = email;
        this.password = password;
    }
}