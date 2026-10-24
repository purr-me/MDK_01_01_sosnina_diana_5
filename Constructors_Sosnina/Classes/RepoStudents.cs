using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Sosnina.Classes
{
    public class RepoStudents
    {
        public static List<Student> AllStudents()
        {
            List<Student> allStudents = new List<Student>();

            allStudents.Add(new Student("Бургина", "Алена", "Евгеньева", true, 4));
            allStudents.Add(new Student("Галкин", "Никита", "Александрович", true, 4));
            allStudents.Add(new Student("Глебов", "Игорь", "Александрович"));
            allStudents.Add(new Student("Граф", "Данил", "Станиславович"));
            allStudents.Add(new Student("Драчев", "Андрей", "Станиславович", false, 3));
            allStudents.Add(new Student("Еловиков", "Степан", "Алексеевич"));
            allStudents.Add(new Student("Кукулькан", "Артур", "Германович"));
            allStudents.Add(new Student("Кусакин", "Данил", "Игоревич"));
            allStudents.Add(new Student("Кылосов", "Матвей", "Михайлович", true, 4));
            allStudents.Add(new Student("Леготкин", "Степан", "Евгеньевич"));
            allStudents.Add(new Student("Мохов", "Арутр", "Александрович"));
            allStudents.Add(new Student("Мухтаров", "Далер", "Эралиевич"));
            allStudents.Add(new Student("Носков", "Андрей", "Вячесавович"));
            allStudents.Add(new Student("Бургина", "Алена", "Евгеньева", true, 4));
            allStudents.Add(new Student("Галкин", "Никита", "Александрович", true, 4));
            allStudents.Add(new Student("Глебов", "Игорь", "Александрович"));
            allStudents.Add(new Student("Граф", "Данил", "Станиславович"));
            allStudents.Add(new Student("Драчев", "Андрей", "Станиславович", false, 3));
            allStudents.Add(new Student("Еловиков", "Степан", "Алексеевич"));
            allStudents.Add(new Student("Кукулькан", "Артур", "Германович"));
            allStudents.Add(new Student("Кусакин", "Данил", "Игоревич"));
            allStudents.Add(new Student("Кылосов", "Матвей", "Михайлович", true, 4));
            allStudents.Add(new Student("Леготкин", "Степан", "Евгеньевич"));
            allStudents.Add(new Student("Мохов", "Арутр", "Александрович"));
            allStudents.Add(new Student("Мухтаров", "Далер", "Эралиевич"));
            allStudents.Add(new Student("Носков", "Андрей", "Вячесавович"));
            return allStudents;

        }
    }
}
