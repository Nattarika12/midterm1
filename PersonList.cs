using System.Collections.Generic;
public class PersonList {
    private List<Person> personList;
    public PersonList() {
        this.personList = new List<Person>();
    }
    public void AddNewPerson(Person person) {
        this.personList.Add(person);
    }
    public void FetchPersonList() {
        Console.WriteLine("List Person");
        Console.WriteLine("========================================");

        foreach(Person person in this.personList) {
            if (person is CurrentStudent) {
                Console.WriteLine("Name Frefix {0} \n Name {1} \n Last Name {2} \n Type: Current Student \n", person.GetName());
            } else if (person is Student ) {
                Console.WriteLine("Name Frefix {0} \n Name {1} \n Last Name {2} \n Type: Student \n", person.GetName());
            }else if (person is Lecturer){
                Console.WriteLine("Name Frefix {0} \n Name {1} \n Last Name {2} \n Type: Lecturer \n", person.GetName());
            }

        }
    }
}