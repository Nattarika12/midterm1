public class Program {
    static PersonList personList;
    static void Main(string[] args) {
        PrintMenuScreen();
        InputMenuFromKeyboard();
    }
    static void PrintMenuScreen() {
        Console.Clear();
        PrintListMenu();
    }
    static void PrintListMenu() {
        Console.WriteLine("================Main Menu Page================");
        Console.WriteLine("==============================================");

        Console.WriteLine("1.Register For The Event");
        Console.WriteLine("2.Participant Statistics");
        Console.WriteLine("3.Sing in");
        Console.WriteLine("==============================================");
    }
    static void InputMenuFromKeyboard() {
        Console.Write("Please input Menu:");
        ListMenu.Menu menu = (ListMenu.Menu)(int.Parse(Console.ReadLine()));
    }
    static void PresentMenu(ListMenu.Menu menu) {
        switch (menu) {
            case ListMenu.Menu.Registration_For_The_Event:
                ShowInputRegistration();
                break;
            case ListMenu.Menu.ShowAllParticipant_Statistice:
                ShowInputStatistice();
                break;
            case ListMenu.Menu.Sing_in:
                ShowSingin();
                break;
            default:
                break;
            
        }
    }
    static void PrintListMenu1(){
         Console.WriteLine("============Welcome To The System============");
        Console.WriteLine("==============================================");

        Console.WriteLine("1.Register For The Event");
        Console.WriteLine("2.Show All Current Student");
        Console.WriteLine("3.Show All Student");
        Console.WriteLine("4.Show All Lecturer");
        Console.WriteLine("5.Log out");
        Console.WriteLine("==============================================");
    }
    static void InputMenuFromKeyboard1() {
        Console.Write("Please input Menu:");
        ListMenu.Menu2 menu2 = (ListMenu.Menu2)(int.Parse(Console.ReadLine()));
    }
    static void PresentMenu(ListMenu.Menu2 menu2) {
        switch (menu2) {
            case ListMenu.Menu2.Registration_For_The_Event:
                InputRegistration_For_The_Event();
                break;
            case ListMenu.Menu2.Show_All_Current_Student:
                Show_All_Current_Student();
                break;
            case ListMenu.Menu2.Show_All_Student:
                Show_All_Student();
            case ListMenu.Menu2.Show_All_Lecturer:
                Show_All_Lecturer();
                break;
            case ListMenu.Menu2.Logout:
                PrintMenuScreen();
                break;
            default:
                break;
        }
    }
    static void InputRegistration_For_The_Event() {
        Console.WriteLine("Show Person");
        Console.WriteLine("===========================================");

        Program.personList.FetchPersonList();

    }   
    static void Show_All_Current_Student(){
        Console.WriteLine("Show All Current Student");
        Console.WriteLine("===========================================");

        Program.personList.CurrentStudent();
    }
}
