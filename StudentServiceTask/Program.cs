using StudentServiceTask.Controller;
using StudentServiceTask.Service;

GroupContoller groups = new GroupContoller();
StudentService studentService = new StudentService();
bool isContinue = true;



//Heleki telebeni elave etmek de, telebeni silmekde propblem. Derse kimi ede bilmesem pis olacaq.

do
{
    Console.WriteLine("1-Qruplara bax\n2-Qrup yarat\n3-Qrup sil\n4-Qrupa kec");
    char key = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (key)
    {
        case '1':
            groups.ShowGroup();
            break;
        case '2':
            groups.AddGroup();
            break;
        case '3':
            groups.Remove();
            break;
        case '4':
            groups.GoGroup();
            break;
        default:
            isContinue = false;
            break;
    }
} while (isContinue);